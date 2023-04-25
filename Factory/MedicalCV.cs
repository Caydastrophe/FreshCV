using Microsoft.AspNetCore.Mvc;

namespace freshCV;

public class MedicalCV : ICVFresh

{
    public List<string> getDetails()
    {
        List<string> bio = new List<string>();
        bio.Add("name is Pedro");
        bio.Add("country is Brazil");
        return bio;

    }

    public List<string> getEducation()
    {
        List<string> education = new List<string>();
        education.Add("PHD cs");
        education.Add("MSC cs");
        return education;
    }

    public List<string> getExperience()
    {
        List<string> experience = new List<string>();
        experience.Add("10 Years Java");
        experience.Add("5 yeras Lisp");
        return experience;
    }

    public List<string> getReferences()
    {
        List<string> reference = new List<string>();
        reference.Add("Great Guy- does research");
        reference.Add("Kinda snobby but can stay  ");
        return reference;
    }

    public List<string> getSkills()
    { 
        List<string> skills = new List<string>();
        skills.Add("10 years java");
        return skills;
    }
}