
/// <summary>
/// Person class with properties Name, Gender, and Age
/// Methods are HaveBirthday and ToString
/// </summary>
/// 


public class Person
{
    // Instance variables
    private string _name;
    private char _gender;
    private int _age;

    // Constructors
    public Person()
    {
        _name = "Unknown";
        _gender = 'U';
        _age = -1;
    }

    public Person(string theName, char theGender, int theAge)
    {
        // Name cannot be the empty string.
        if (theName != "")
        {
            _name = theName;
        }
        else
        {
            _name = "Unknown";
        }

        if (theGender == 'F' || theGender == 'M' || theGender=='U')
        {
            _gender = theGender;
        }
        else
        {
            _gender = 'U';
        }

        // Age must be nonnegative.  -1 means illegal age.
        if (theAge >= 0)
        {
            _age = theAge;
        }
        else
        {
            _age = -1;
        }
    }

    // Read only property
    public string Name
    {
        get { return _name; }
    }

    // Read only property
    public char Gender
    {
        get { return _gender; }
    }

    // Read/write property
    public int Age
    {
        get { return _age; }

        set
        {
            if (value >= 0)
            {
                _age = value;
            }
            else
            {
                _age = -1;
            }
        }
    }

    public void HaveBirthday()
    {
        if (_age >= 0)
        {
            _age++;
        }
    }

    public override string ToString()
    {
        return "Name " + _name + "Gender: " + _gender + "Age: " + _age;
    }
}
