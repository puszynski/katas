
namespace Katas.Tests
{
    public class OutVariable
    {
         // Let's assume we want to call the following method
        void GetName(out string name) => name = "James Tiberius Kirk";
        string Example1()
        {
            string name;
            GetName(out name);
            return name;
        }

        string Example2()
        {
            GetName(out string name); // in 7.0 variable can be assign inside
            return name;
        }

        string Example3()
        {
            GetName(out var name); // var can be used
            return name;
        }

       string Example4(string ageAsString)
        {
            if (int.TryParse(ageAsString, out var age)) // common use
                return $"In 10 years a person will be {age + 10} years old";
            return null;
        }
    }

    // PL: "odrzuty"
    public class Discards
    {
        private int DoSomethingAndReturnValue() => 24;
        private void Example1()
        {
            // Get the return value
            var myValue = DoSomethingAndReturnValue();
            // Ignore the return value
            DoSomethingAndReturnValue();
        }

        private void DoSomethingAndGiveValue(out int value) => value = 42;
        private void Example2()
        {
            DoSomethingAndGiveValue(out var ignoredVariable); // in scope we create new value
        }

        //how to ignore it?
        private void Example4()
        {
            DoSomethingAndGiveValue(out int _); // The underscore character (_)  is used to indicate that the parameter should be ignored. It’s like it is the write-only parameter
            DoSomethingAndGiveValue(out _); // also like that

            //return _; // error - y cant return it
        }

        //when using touples - more variables can be ignored
        private void GetManyValues(out int first, out int second, out int third, out int forth) =>
            first = second = third = forth = 13;

        private void Example5()
        {
            GetManyValues(out _, out int thisOneWeNeed, out _, out _);
        }

        //discard can be use not only with out:
        private void Example6()
        {
            _ = 1 + 2;
            // return _;  // will not work
        }
    }
}