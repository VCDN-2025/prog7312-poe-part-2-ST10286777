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

            AddEvent(new Event { Name = "Tech Expo 2025", Category = "Technology", EventDate = new DateTime(2026, 6, 1), Location = "Cape Town Convention Center", Description = "Annual technology exhibition showcasing latest innovations" });
            AddEvent(new Event { Name = "Food Festival", Category = "Food", EventDate = new DateTime(2026, 7, 15), Location = "Durban Beachfront", Description = "International food festival with local and international cuisines" });
            AddEvent(new Event { Name = "Jazz in the Park", Category = "Music", EventDate = new DateTime(2025, 12, 20), Location = "Johannesburg Botanical Gardens", Description = "Open air jazz concert featuring local artists" });
            AddEvent(new Event { Name = "Marathon Run", Category = "Sports", EventDate = new DateTime(2025, 11, 10), Location = "Pretoria City Center", Description = "Annual city marathon for all fitness levels" });
            AddEvent(new Event { Name = "Art Exhibition", Category = "Arts", EventDate = new DateTime(2025, 10, 25), Location = "Stellenbosch Gallery", Description = "Contemporary art exhibition by local artists" });
            AddEvent(new Event { Name = "Business Summit", Category = "Business", EventDate = new DateTime(2025, 11, 5), Location = "Sandton Convention Center", Description = "Networking and business development summit" });
            AddEvent(new Event { Name = "Wine Tasting", Category = "Food", EventDate = new DateTime(2026, 8, 12), Location = "Franschhoek Valley", Description = "Premium wine tasting experience" });
            AddEvent(new Event { Name = "Comedy Night", Category = "Entertainment", EventDate = new DateTime(2025, 6, 18), Location = "Cape Town Comedy Club", Description = "Stand-up comedy featuring top comedians" });
            AddEvent(new Event { Name = "Yoga Workshop", Category = "Health", EventDate = new DateTime(2025, 7, 22), Location = "Kirstenbosch Gardens", Description = "Beginner-friendly yoga and meditation workshop" });
            AddEvent(new Event { Name = "Book Fair", Category = "Education", EventDate = new DateTime(2025, 8, 30), Location = "Johannesburg Library", Description = "Annual book fair with author signings" });
            AddEvent(new Event { Name = "Tech Startup Pitch", Category = "Technology", EventDate = new DateTime(2025, 9, 5), Location = "Tshimologong Precinct", Description = "Startup pitching competition for tech entrepreneurs" });
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
            }

            //Track category filters
            if (!string.IsNullOrEmpty(categoryFilter) && !categoryFilter.Equals("All Categories", StringComparison.OrdinalIgnoreCase))
            {
                if (!categorySearchCount.ContainsKey(categoryFilter))
                    categorySearchCount[categoryFilter] = 0;
                categorySearchCount[categoryFilter]++;
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

            return eventDirectory.Values
                .Where(e => e.Category.Equals(category, StringComparison.OrdinalIgnoreCase))
                .ToList();
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
            // Upcoming events
            var now = DateTime.Now;
            var upcoming = eventDirectory.Values.Where(e => e.EventDate >= now).ToList();

            // If their is no search data from user, returns a default recommendation
            if (searchAnalytics.Count == 0 && categorySearchCount.Count == 0)
            {
                return upcoming.OrderBy(e => e.EventDate).Take(maxResults).ToList();
            }

            var recommendations = new List<Event>();

            // Top search terms
            var topSearches = searchAnalytics.OrderByDescending(x => x.Value).Select(x => x.Key).Take(3).ToList();

            // Top categories
            var topCategories = categorySearchCount.OrderByDescending(x => x.Value).Select(x => x.Key).Take(2).ToList();

            // Recommend by terms first
            foreach (var term in topSearches)
            {
                if (string.IsNullOrEmpty(term)) continue;
                var matches = upcoming.Where(e =>
                    (!string.IsNullOrEmpty(e.Name) && e.Name.ToLower().Contains(term)) ||
                    (!string.IsNullOrEmpty(e.Description) && e.Description.ToLower().Contains(term)) ||
                    (!string.IsNullOrEmpty(e.Category) && e.Category.ToLower().Contains(term))
                ).Take(2);

                recommendations.AddRange(matches);
            }

            // Recommend by top categories
            foreach (var cat in topCategories)
            {
                var catMatches = upcoming.Where(e => !string.IsNullOrEmpty(e.Category) && e.Category.Equals(cat, StringComparison.OrdinalIgnoreCase)).Take(2);
                recommendations.AddRange(catMatches);
            }

            //Makes sure there are no duplicate events in the recommendations
            var distinctRecommendations = recommendations
                .GroupBy(e => e.EventId)
                .Select(g => g.First())
                .Take(maxResults)
                .ToList();

            if (!distinctRecommendations.Any())
                distinctRecommendations = upcoming.OrderBy(e => e.EventDate).Take(maxResults).ToList();

            return distinctRecommendations;
        }
    }

}
