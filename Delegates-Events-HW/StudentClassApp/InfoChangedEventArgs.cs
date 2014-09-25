using System;

namespace StudentClassApp
{
    public class InfoChangedEventArgs : EventArgs
    {
        private string propertyName;
        private dynamic oldValue;
        private dynamic newValue;

        public InfoChangedEventArgs(string name, dynamic oldValue, dynamic newValue)
        {
            this.PropertyName = name;
            this.OldValue = oldValue;
            this.NewValue = newValue;
        }

        public string PropertyName
        {
            get { return propertyName; }
            set { propertyName = value; }
        }

        public dynamic OldValue
        {
            get { return oldValue; }
            set { oldValue = value; }
        }

        public dynamic NewValue
        {
            get { return newValue; }
            set { newValue = value; }
        }
    }
}
