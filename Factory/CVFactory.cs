using Microsoft.AspNetCore.Mvc;

namespace freshCV;

public class CVFactory
{
        public ICVFresh returnType;

        public ICVFresh getCV(string cvType)
        {
            switch(cvType)
            {
                case("Academic"):
                returnType = new AcademicCV();
                break;

                case("Industry"):
                returnType = new IndustryCV();
                break;
            }

            return returnType;    
        }
}