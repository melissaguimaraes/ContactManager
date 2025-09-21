using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager.Helper
{
    internal class FileHandler
    {

        // static class to write into json files with custom object/generic specification
        private FileHandler() 
        {
            // singleton instance
        }

        /*
        Adds a, with generic specified, object to a json file

        @parameter: filepath
        @parameter: obj (object write to file)
        */
        public static void AddObjectToFile<T>(string filepath, T obj) 
        {
            List<T> objects = GetObjectsAsList<T>(filepath);

            objects.Add(obj);

            WriteObjectsToFile(filepath, objects);
        }

        /*
        Returns list of object from json file

        @parameter: filepath

        @returns: List<T> (specified objects as list) -> empy list if no objects
        */
        public static List<T> GetObjectsAsList<T>(string filepath)
        {
            if (!File.Exists(filepath))
                return new List<T>();

            string json = File.ReadAllText(filepath);

            // saves object type as attribute, needed for NewtonSoft.Json
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            };

            return JsonConvert.DeserializeObject<List<T>>(json, settings) ?? new List<T>();
        }

        /*
        Writes List of generic specified objects to json file

        @parameter: filepath
        @parameter: objects
        */
        public static void WriteObjectsToFile<T>(string filepath, List<T> objects)
        {
            // saves object type as attribute, needed for NewtonSoft.Json
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                // json indented format
                Formatting = Formatting.Indented
            };

            string json = JsonConvert.SerializeObject(objects, settings);
            File.WriteAllText(filepath, json);
        }

    }
}
