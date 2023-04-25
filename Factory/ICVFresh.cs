using Microsoft.AspNetCore.Mvc;

namespace freshCV;

public interface ICVFresh
{
    List<String> getEducation ();

    List<String> getExperience ();

    List<String> getDetails ();

    List<String> getSkills ();

    List<String> getReferences ();
}