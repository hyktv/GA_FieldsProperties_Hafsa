using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_FieldsProperties_Hafsa
{
    public class Person
    {
        //private feild - encapsulates the data to prevent direct external access
        private string _name;

        public string Name
        { 
            get { return _name; } //getter - returns the calue of _name
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    throw new ArgumentException("Name cannot be null or empty");
            } //setter - assigns a value to _name

        } //Name

        //readonly properties include a get accessor but no set accessor
        public string ReadOnlyName
        {
            get { return _name; }

        }//ReadOnlyName

        //writeonly properties include a set accessor but no get accessor
        public string WriteOnlyName
        {
            set { _name = value; }

        }//WriteOnlyName


    } //class


}//namespace
