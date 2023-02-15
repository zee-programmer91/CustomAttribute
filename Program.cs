using System;

[System.AttributeUsage(System.AttributeTargets.Class |  
                       System.AttributeTargets.Struct)  
]  
public class DeveloperAttribute : Attribute  
{  
    private string Name;
    private string Surname;
    public string CodeVersion;  
  
    public DeveloperAttribute(string name, string surname)  
    {  
        this.Name = name;
        this.Surname =  surname;
        this.CodeVersion = "1.0.0";  
    }

    public DeveloperAttribute(string name, string surname, string codeVersion)  
    {  
        this.Name = name;
        this.Surname = surname;
        this.CodeVersion = codeVersion;  
    }  
}