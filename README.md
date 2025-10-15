<div align="center">
  <h1> Municipal Services Application </h1>
</div>

<div align="center">

<img width="250" height="250" alt="Logo" src="https://github.com/user-attachments/assets/086c0e9c-1e3b-424b-86b8-7798edaaf4c7" />

  <h3>Community Engagement Made Simple</h3>

  <p>A C# .NET Framework Windows Forms project designed to streamline citizen engagement with municipal services in South Africa.</p>

  ![C#](https://img.shields.io/badge/C%23-11.0-purple?style=for-the-badge&logo=csharp)
  ![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2+-blue?style=for-the-badge&logo=dotnet)
  ![Windows Forms](https://img.shields.io/badge/Windows%20Forms-Desktop-green?style=for-the-badge&logo=windows)
  ![Visual Studio](https://img.shields.io/badge/Visual%20Studio-2019%2F2022-blueviolet?style=for-the-badge&logo=visualstudio)

<p>Part 1 Demo: </p>
<a href="https://youtu.be/82EuWq-pjY8"> <img src="https://img.shields.io/badge/Watch_Demo-YouTube-red?style=for-the-badge&logo=youtube" alt="Watch the Demo for Part 1 on YouTube"> </a>
<p> Part 2 Demo:</p> 
<a href="https://youtu.be/xHGMzAuiUck"> <img src="https://img.shields.io/badge/Watch_Demo-YouTube-red?style=for-the-badge&logo=youtube" alt="Watch the Demo for Part 2 on YouTube"> </a>
</div>
</div>

---

## 📖 Overview

The *Municipal Services Application* is a Windows Forms desktop project that enables residents to report local issues (e.g., potholes, water leaks, waste management) and provides immediate feedback on community impact.

This application was developed as **Part 1 of a Portfolio of Evidence (PoE)** for the *Advanced Application Development* module.

---

## ✨ Features (Part 1 and 2 – Implemented)

### 🏠 Main Menu
A clean, user-friendly interface presenting three main functions:
- Report Issues and Request Services  
- Events and Announcements 
- Status of Service Request *(coming soon)*  

### 📝 Report Issues
- **Detailed Form**: capture street, suburb, city, province, postal code, category, and description.  
- **File Attachment**: attach images/documents *(max 10MB)*.  
- **Form Validation**: required fields must be completed before submission.  
- **User Engagement**: confirmation message with:  
  - Unique issue ID  
  - Community statistics *(e.g., “Community Impact: 5 issues reported, 4 resolved”)*  
- **Data Management**: custom `IssueCollection` data structure (array-based) to store and manage issues efficiently.

### 📝 Events and Announcements
- **Displays all events**: All events are displayed when form loads.  
 **Advanced Search Functionality**: 
  - Search by name, category, or date
  - Real-time category filtering
  - Multi-criteria sorting (date, name, category)
- **Search Analytics Display**:
  - Most popular searched category 
  - Total number of searches conducted
- **Displays Recently Viewed Events**: Stack-based tracking of last 4 viewed events
- **Smart Recommendation System**:
  - Category preferences (70% weight)
  - Search term history (30% weight)
  - If their is no user search history the closest upcoming events will be prioritized.

### 🔜 Coming Soon
- Service Request Status  

---

## ⚙️ Prerequisites

| Requirement | Version / Notes |
|-------------|-----------------|
| **OS** | Windows 7 or later |
| **IDE** | Microsoft Visual Studio 2019 or later |
| **Framework** | .NET Framework 4.7.2+ |

---

## 🚀 How to Compile and Run

### 1. Open the Solution
1. Launch Visual Studio  
2. *File > Open > Project/Solution...*  
3. Select **Municipal_Services.sln**

### 2. Restore Packages
- NuGet packages restore automatically  
- If prompted, allow restore  

### 3. Build the Solution
- *Build > Build Solution* (or press **Ctrl+Shift+B**)  

### 4. Run the Application
- Press **F5** or click the green Start button  

---

## 📱 How to Use the Application

### Starting Up
- Launch the app → you’ll see the **Main Menu**

### Reporting an Issue
1. Click **Report Issues**  
2. Fill in all fields:  
 - Street Address: e.g., *“123 Main Street”*  
 - Suburb: area name  
 - City: city name  
 - Province: select from dropdown  
 - Postal Code: valid SA postal code  
 - Category: choose from dropdown  
 - Description: detailed description of the issue  
3. *(Optional)* Attach a file → Browse > Select File > Open  
4. Click **Submit Report**  
5. Receive confirmation with issue ID + community impact  
6. Use **Clear Form** to reset, or **Back to Main Menu** to return

### Events and Announcements
1. Click **Events and Announcements**  
2. View a list of all Events and Announcements
3. **Search**: Enter term in search bar 
4. **Filter**: Use category dropdown to filter by specific event types
5. **Sort**: Organize events by date, name, or category
6. **View Details**: Click any event to see full details
7. **Track Activity**: Watch search analytics update in real-time
8. **Get Recommendations**: View personalized suggestions in "Recommended For You" section
9. **Review History**: See last 4 viewed events in "Recently Viewed" panel
10. Use **Clear Filters** to reset search
11. Select **Back to Main Menu** to return to menu

### Exiting
- Click **Exit** on any form  

---

## 📂 Project Structure

Municipal_Services/
│
├── MainMenu.cs # Main navigation form
├── ReportIssues.cs # Form for submitting reports
├── Issue.cs # Defines Issue properties
├── IssueCollection.cs # Custom collection (dynamic array)
├── IssueManager.cs # Manages the collection of issues
├── Event.cs # Defines Issue properties
├── EventManager.cs # Manages all the Event Methods
├── EventAnnouncements.cs # Displays all the Events
├── Program.cs # Entry point
└── README.md # Documentation

text

## 🗄️ Data Structures Implemented

### Part 1: Issue Management
#### `IssueCollection` Class
- **Custom-built collection** using a **dynamically resizing array** to store `Issue` objects  
- **Supports**:
  - Add new issues
  - Remove existing issues
  - Find by ID, category, or location
  - Automatic capacity management

### Part 2: Events and Announcements System

#### Primary Data Structures

##### 1. `SortedDictionary<Guid, Event> eventDirectory`
- **Purpose**: Primary storage for all event data with automatic sorting
- **Key Features**:
  - Guaranteed O(log n) time complexity for insert, delete, and search operations
  - Automatic sorting by GUID for efficient event retrieval
  - Maintains event uniqueness through GUID keys
- **Usage**: Central repository for all event management operations

##### 2. `HashSet<string> eventCategories`
- **Purpose**: Efficient management of unique event categories
- **Key Features**:
  - O(1) average time complexity for add, remove, and contains operations
  - Ensures no duplicate categories
  - Enables fast category-based filtering and validation
- **Usage**: Populates category dropdown filters and validates new categories

##### 3. `Dictionary<string, int> searchAnalytics`
- **Purpose**: Tracks user search patterns and term frequency
- **Key Features**:
  - O(1) average time complexity for access and updates
  - Maps search terms to their usage frequency
  - Enables search term-based recommendations
- **Usage**: Powers the recommendation system and search analytics display

##### 4. `Dictionary<string, int> categorySearchCount`
- **Purpose**: Tracks category-based search and filter usage
- **Key Features**:
  - Monitors which categories users interact with most frequently
  - Provides data for category-weighted recommendations
  - Enables "Most Popular Category" analytics
- **Usage**: Primary input for category-focused recommendation algorithm

##### 5. `Stack<Event> viewedEvents`
- **Purpose**: Tracks recently viewed events using LIFO principle
- **Key Features**:
  - O(1) time complexity for push and pop operations
  - Maintains last 4 uniquely viewed events
  - Automatic duplicate prevention and size limiting
- **Usage**: Displays "Recently Viewed" events section

#### Advanced Algorithm Implementation

##### Smart Recommendation System
- **Priority-based algorithm** that weights categories (70%) higher than search terms (30%)
- **Four-tier recommendation strategy**:
  1. **Category Priority**: Events from most-searched categories
  2. **Search Term Fallback**: Events matching popular search terms
  4. **Upcoming Events**: Temporal relevance as final fallback
- **Intelligent Duplicate Prevention**: Ensures diverse recommendations

---
## 🎯 User Engagement Strategy

The system implements a **Community Impact Feedback** strategy:  
- After submitting a report, the user is shown a message with statistics  
  *(e.g., total issues reported, estimated resolved issues)*  
- This fosters a **sense of community** and highlights the **value of participation**  

---

