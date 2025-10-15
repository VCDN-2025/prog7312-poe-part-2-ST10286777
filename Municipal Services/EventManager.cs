using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Municipal_Services
{
    public class EventManager
    {
        // Data Structures

        //Primary Storage used to manage event data
        private SortedDictionary<Guid, Event> eventDirectory = new SortedDictionary<Guid, Event>();
        //HashSet used to manage unique event categories for efficient lookups
        private HashSet<string> eventCategories = new HashSet<string>();
        //Dictionary to track search analytics, mapping search terms to their frequency
        private Dictionary<string, int> searchAnalytics = new Dictionary<string, int>();
        //Tracks the number of searches per category
        private Dictionary<string, int> categorySearchCount = new Dictionary<string, int>();
        // Recently viewed
        private Stack<Event> viewedEvents = new Stack<Event>();

        // Tracks total searches
        private int totalSearches = 0;

        public IEnumerable<Event> GetAllEvents() => eventDirectory.Values;
        public HashSet<string> GetCategories() => eventCategories;

        public EventManager() 
        {

            PopulateSampleData();
        }

        //Populating Sample Data
        public void PopulateSampleData()
        {
            eventDirectory.Clear();
            eventCategories.Clear();
            searchAnalytics.Clear();
            categorySearchCount.Clear();
            viewedEvents.Clear();

            AddEvent(new Event { Name = "DRAKENSBERG BOYS CHOIR - LIVE CONCERT", Category = "Entertainment", EventDate = new DateTime(2025, 10, 19), Location = "Drakie campus in the picturesque Drakensberg!", Description = "Magical music experience of masterpieces performed by the talented and world-acclaimed Drakensberg Boys " });
            AddEvent(new Event { Name = "Food Festival", Category = "Food", EventDate = new DateTime(2026, 7, 15), Location = "Durban Beachfront", Description = "International food festival with local and international cuisines" });
            AddEvent(new Event { Name = "Jazz in the Park", Category = "Music", EventDate = new DateTime(2025, 12, 20), Location = "Johannesburg Botanical Gardens", Description = "Open air jazz concert featuring local artists" });
            AddEvent(new Event { Name = "Sani Stagger Endurance Race", Category = "Sports", EventDate = new DateTime(2025, 11, 8), Location = " Sani Pass Hotel", Description = "Annual city marathon for all fitness levels, Distances: 21km half; 42km marathon." });
            AddEvent(new Event { Name = "Art Exhibition", Category = "Arts", EventDate = new DateTime(2025, 10, 25), Location = "Stellenbosch Gallery", Description = "Contemporary art exhibition by local artists" });
            AddEvent(new Event { Name = "Business Summit", Category = "Business", EventDate = new DateTime(2025, 11, 5), Location = "Sandton Convention Center", Description = "Networking and business development summit" });
            AddEvent(new Event { Name = "Wine Tasting", Category = "Food", EventDate = new DateTime(2026, 8, 12), Location = "Franschhoek Valley", Description = "Premium wine tasting experience" });
            AddEvent(new Event { Name = "Comedy Night", Category = "Entertainment", EventDate = new DateTime(2025, 6, 18), Location = "Cape Town Comedy Club", Description = "Stand-up comedy featuring top comedians" });
            AddEvent(new Event { Name = "Yoga Workshop", Category = "Health", EventDate = new DateTime(2025, 7, 22), Location = "Kirstenbosch Gardens", Description = "Beginner-friendly yoga and meditation workshop" });
            AddEvent(new Event { Name = "Book Fair", Category = "Education", EventDate = new DateTime(2025, 8, 30), Location = "Johannesburg Library", Description = "Annual book fair with author signings" });
            AddEvent(new Event { Name = "Drak Challenge", Category = "Sports", EventDate = new DateTime(2025, 9, 5), Location = "Southern Drakensberg in KwaZulu-Natal", Description = "This is one of the three largest races in South Africa and covers a massive 72 kilometres over the course of the event" });
            AddEvent(new Event { Name = "Seafood Festival", Category = "Food", EventDate = new DateTime(2027, 10, 1), Location = "Hout Bay Harbor", Description = "Fresh seafood and maritime activities" });
            AddEvent(new Event { Name = "Heritage Day", Category = "Cultural", EventDate = new DateTime(2025, 11, 24), Location = "Union Buildings, Pretoria", Description = "National heritage day celebrations" });
            AddEvent(new Event { Name = "Science Fair", Category = "Education", EventDate = new DateTime(2025, 10, 15), Location = "Sci-Bono Discovery Center", Description = "Interactive science exhibition for all ages" });
            AddEvent(new Event { Name = "Farmers Market", Category = "Food", EventDate = new DateTime(2025, 10, 18), Location = "Neelsie Student Center", Description = "Weekly farmers market with organic produce" });
           
        }

        //Adds an event to the directory and updates categories
        private void AddEvent(Event eventItem)
        {
            // Ensure the event has an ID
            if (eventItem.EventId == Guid.Empty)
                eventItem.EventId = Guid.NewGuid();

            eventDirectory[eventItem.EventId] = eventItem;
            if (!string.IsNullOrWhiteSpace(eventItem.Category))
                eventCategories.Add(eventItem.Category);
        }


        // Search for event using event's name, category, or date
        public List<Event> SearchEvents(string term, string categoryFilter = null)
        {
            term = term?.Trim();
            string termLower = string.IsNullOrEmpty(term) ? null : term.ToLower();

            // Track search analytics
            if (!string.IsNullOrEmpty(term))
            {
                if (!searchAnalytics.ContainsKey(termLower))
                    searchAnalytics[termLower] = 0;
                searchAnalytics[termLower]++;
                totalSearches++;
            }

            //Track category filters
            if (!string.IsNullOrEmpty(categoryFilter) && !categoryFilter.Equals("All Categories", StringComparison.OrdinalIgnoreCase))
            {
                if (!categorySearchCount.ContainsKey(categoryFilter))
                    categorySearchCount[categoryFilter] = 0;
                categorySearchCount[categoryFilter]++;
                totalSearches++;
            }

            var results = eventDirectory.Values.AsEnumerable();

            // Apply search term filter
            if (!string.IsNullOrEmpty(termLower))
            {
                results = results.Where(e =>
                    (!string.IsNullOrEmpty(e.Name) && e.Name.ToLower().Contains(termLower)) ||
                    (!string.IsNullOrEmpty(e.Category) && e.Category.ToLower().Contains(termLower)) ||
                    e.EventDate.ToString("yyyy-MM-dd").Contains(termLower)
                );
            }

            // Apply category filter
            if (!string.IsNullOrEmpty(categoryFilter) && !categoryFilter.Equals("All Categories", StringComparison.OrdinalIgnoreCase))
            {
                results = results.Where(e => e.Category.Equals(categoryFilter, StringComparison.OrdinalIgnoreCase));
            }

            return results.ToList();
        }

        // Filter events by category
        public List<Event> FilterEventsByCategory(string category)
        {
            if (string.IsNullOrEmpty(category) || category == "All Categories")
                return eventDirectory.Values.ToList();

            if (!categorySearchCount.ContainsKey(category))
                categorySearchCount[category] = 0;
            categorySearchCount[category]++;
            totalSearches++;

            return eventDirectory.Values
                .Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();
        }

        // NEW: Methods to get search analytics data
        public int GetTotalSearches()
        {
            return totalSearches;
        }

        public string GetMostPopularCategory()
        {
            if (categorySearchCount.Count == 0)
                return "None";

            var mostPopular = categorySearchCount
                .OrderByDescending(x => x.Value)
                .FirstOrDefault();

            return mostPopular.Key ?? "None";
        }

        public int GetMostPopularCategoryCount()
        {
            if (categorySearchCount.Count == 0)
                return 0;

            return categorySearchCount
                .OrderByDescending(x => x.Value)
                .FirstOrDefault().Value;
        }

        public Dictionary<string, int> GetCategorySearchStats()
        {
            return new Dictionary<string, int>(categorySearchCount);
        }

        public Dictionary<string, int> GetSearchTermStats()
        {
            return new Dictionary<string, int>(searchAnalytics);
        }


        // Sort events by date, category, or name
        public List<Event> SortEvents(string sortBy)
        {
            var events = eventDirectory.Values.ToList();

            switch (sortBy)
            {
                case "Date":
                    return events.OrderBy(e => e.EventDate).ToList();
                case "Category":
                    return events.OrderBy(e => e.Category).ThenBy(e => e.EventDate).ToList();
                case "Name":
                    return events.OrderBy(e => e.Name).ToList();
                default:
                    return events;
            }
        }

        //Displays recently viewed events
        public void AddToRecentlyViewed(Event ev)
        {

            // Remove duplicates from stack 
            var items = viewedEvents.ToList();
            items.RemoveAll(x => x.EventId == ev.EventId);

            // Insert the last viewed event first
            items.Insert(0, ev);

            // Limits the amount of recently viewed events to 5
            if (items.Count > 5) items = items.Take(5).ToList();
            viewedEvents = new Stack<Event>(items);
        }

        public List<Event> GetLastViewedEvents()
        {
            return viewedEvents.ToList();
        }

        // Recommended events based on search history and categories
        public List<Event> GetRecommendations(int maxResults = 4)
        {
            var now = DateTime.Now;
            var upcoming = eventDirectory.Values.Where(e => e.EventDate >= now).ToList();

            if (searchAnalytics.Count == 0 && categorySearchCount.Count == 0)
            {
                return upcoming.OrderBy(e => e.EventDate).Take(maxResults).ToList();
            }

            var recommendations = new List<Event>();

            // Get weighted recommendations (70% categories, 30% search terms)
            var topCategories = categorySearchCount
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .Take(2)
                .ToList();

            var topSearches = searchAnalytics
                .OrderByDescending(x => x.Value)
                .Select(x => x.Key)
                .Take(2)
                .ToList();

            // CATEGORIES FIRST: 70% of recommendations from categories
            int categoryCount = (int)Math.Ceiling(maxResults * 0.7);
            foreach (var category in topCategories)
            {
                if (recommendations.Count >= categoryCount) break;

                var categoryEvents = upcoming
                    .Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                    .Where(e => !recommendations.Contains(e))
                    .OrderBy(e => e.EventDate)
                    .Take(categoryCount - recommendations.Count);

                recommendations.AddRange(categoryEvents);
            }

            // SEARCH TERMS SECOND: 30% of recommendations from search terms
            int searchTermCount = maxResults - recommendations.Count;
            foreach (var term in topSearches)
            {
                if (recommendations.Count >= maxResults) break;

                var termEvents = upcoming
                    .Where(e =>
                        e.Name.ToLower().Contains(term) ||
                        e.Description.ToLower().Contains(term) ||
                        e.Category.ToLower().Contains(term)
                    )
                    .Where(e => !recommendations.Contains(e))
                    .OrderBy(e => e.EventDate)
                    .Take(1);

                recommendations.AddRange(termEvents);
            }

            // Fill any remaining slots with upcoming events
            if (recommendations.Count < maxResults)
            {
                var remaining = upcoming
                    .Where(e => !recommendations.Contains(e))
                    .OrderBy(e => e.EventDate)
                    .Take(maxResults - recommendations.Count);

                recommendations.AddRange(remaining);
            }

            return recommendations.Take(maxResults).ToList();
        }
    }

}
