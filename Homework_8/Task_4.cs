using System.Xml.Linq;

namespace Homework_8
{
    internal static class Task_4
    {
        static string path = "Person.xml";

        public static void Run()
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Person person = new Person();
            person.Name = RequestString("Введите ФИО");
            person.Address = new Address();
            person.Address.Street = RequestString("Введите улицу");
            person.Address.HouseNumber = RequestString("Введите номер дома");
            person.Address.FlatNumber = RequestString("Введите номер квартиры");
            person.Phones = new Phones();
            person.Phones.MobilePhone = RequestString("Введите мобильный номер");
            person.Phones.FlatPhone = RequestString("Введите домашний номер");

            XElement xPerson = new XElement(nameof(Person));
            XElement xAddress = new XElement(nameof(Address));
            XElement xPhones = new XElement(nameof(Phones));

            XElement xStreet = new XElement(nameof(person.Address.Street), person.Address.Street);
            XElement xHouseNumber = new XElement(nameof(person.Address.HouseNumber), person.Address.HouseNumber);
            XElement xFlatNumber = new XElement(nameof(person.Address.FlatNumber), person.Address.FlatNumber);

            XElement mobilePhone = new XElement(nameof(person.Phones.MobilePhone), person.Phones.MobilePhone);
            XElement flatPhone = new XElement(nameof(person.Phones.FlatPhone), person.Phones.FlatPhone);

            xPerson.SetAttributeValue("name", person.Name);
            xPerson.Add(xAddress, xPhones);
            xAddress.Add(xStreet, xHouseNumber, xFlatNumber);
            xPhones.Add(mobilePhone, flatPhone);

            Console.WriteLine(xPerson);

            using (StreamWriter stream = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write)))
            {
                stream.Write(xPerson);
            }
        }

        private static string RequestString(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        class Person
        {
            public string Name;
            public Address Address;
            public Phones Phones;
        }

        class Address
        {
            public string Street;
            public string HouseNumber;
            public string FlatNumber;
        }

        class Phones
        {
            public string MobilePhone;
            public string FlatPhone;
        }
    }
}
