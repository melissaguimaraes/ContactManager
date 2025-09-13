using ContactManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ContactManager.Helper
{
    /*
     class for activity management
     */
    internal class ActivityHandler
    {
        private static ActivityHandler _activityHandler = new ActivityHandler();

        // local file to save activities
        private static string activity_path = "Data/activities.json";

        private ActivityHandler() { }

        /*
         overloading constructor

        @return: _activityHandler
         */
        public static ActivityHandler GetActivityHandler()
        {
            return _activityHandler;
        }

        /*
         returns list for all activities

        @return: activity
         */
        public List<ActivityComment> GetActivityComments()
        {
            string json = File.ReadAllText(activity_path);

            List<ActivityComment> activity = JsonSerializer.Deserialize<List<ActivityComment>>(json);

            return activity;
        }

        /*
        get activities for specific user

        @parameter: contact
        @return: ContactComments (sorted)
         */
        public List<ActivityComment> GetActivityComments(Contact contact)
        {
            List<ActivityComment> ContactComments = new List<ActivityComment>();
            List<ActivityComment> AllComments = GetActivityComments();

            foreach (ActivityComment comment in AllComments)
            {
                if (comment.ContactID == contact.EmployeeNumber)
                {
                    ContactComments.Add(comment);
                }
            }
            // comments are orderd by timestamp descending 
            return ContactComments.OrderByDescending(c => c.Timestamp).ToList();
        }

        /*
         adds comment and saves it locally

         @parameter: activitycomment
         */
        public void SaveActivity(ActivityComment activityComment)
        {
            List<ActivityComment> comments = GetActivityComments();

            comments.Add(activityComment);

            WriteToFile(comments);

        }

        /*
        writes and converts comment in json file
         
        @parameter: comments
         */
        public void WriteToFile(List<ActivityComment> comments)
        { 
            JsonSerializerOptions options = new JsonSerializerOptions { WriteIndented=true};

            string json = JsonSerializer.Serialize(comments, options);

            File.WriteAllText(activity_path, json);
        }

    }
}
