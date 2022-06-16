using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AmphiSys.Monitor.Client.Service
{
    public class KnownTypesBinder : ISerializationBinder
    {
        public IList<Type> KnownTypes { get; set; }

        // Return type of an object.
        /// <summary>
        /// Return the type of an object for deserilizing from JSON.
        /// This is done by returning the type of the matching object 
        /// from the list of KnownTypes by comparing input string
        /// with object types in the list.
        /// NOTE: assembly name is not being used in this project.
        /// </summary>
        /// <returns>
        /// Type of class.
        /// </returns>
        /// <param name="assemblyName">Name of assembly.</param>
        /// <param name="typeName">Name of type.</param>
        public Type BindToType(string assemblyName, string typeName)
        {
            return KnownTypes.SingleOrDefault(t => t.Name == typeName);
        }

        // Bind the name of an object.
        /// <summary>
        /// Binds the name of an object by taking objecttype as input
        /// and passing out the type name as a string.
        /// This is done for serializing the object name to JSON.
        /// NOTE: assembly name is not being used in this project.
        /// </summary>      
        /// <param name="serializedType">Type of serialized.</param>
        /// <param name="assemblyName">Name of type.</param>
        /// <param name="typeName">Name of type.</param>
        public void BindToName(Type serializedType, out string assemblyName, out string typeName)
        {
            assemblyName = null;
            typeName = serializedType.Name;
        }
    }
}