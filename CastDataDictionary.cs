// File:        CastDataDictionary.cs
// Assignment:  Assignment 3 - MongoDB
// Programmer:  Harley Boss
// Class:       ATT
// Date:        March 29th 2020
// Description: Custom dictionary that allows for easy inserting of actors into cast list



using System.Collections;
using System.Collections.Generic;
namespace A3_MongoDB_hboss {
    class CastDataDictionary : IEnumerable {

        private Dictionary<Movie, List<string>> internalDictionary = new Dictionary<Movie, List<string>>();

        public void Add(Movie key, string value) {
            if (this.internalDictionary.ContainsKey(key)) {
                List<string> list = this.internalDictionary[key];
                if (list.Contains(value) == false) {
                    list.Add(value);
                }
            } else {
                List<string> list = new List<string>();
                list.Add(value);
                this.internalDictionary.Add(key, list);
            }
        }

        IEnumerator IEnumerable.GetEnumerator() {
            // this calls the IEnumerator<Foo> GetEnumerator method
            // as explicit method implementations aren't used for method resolution in C#
            // polymorphism (IEnumerator<T> implements IEnumerator)
            // ensures this is type-safe
            return internalDictionary.GetEnumerator();
        }
    }
}
