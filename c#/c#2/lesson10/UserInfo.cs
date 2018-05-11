using System;
namespace lesson10
{
    public class UserInfo
    {
        public static Name UIName(Name obj)
        {
            obj.myName = "Name of user is " + obj.myName;
            return obj;
        }
        public static FamilyAndName UIFamilyName(FamilyAndName obj)
        {
            obj.myFamily = "Имя и фамилия: \"" + obj.myName + " " + obj.myFamily + "\"";
            return obj;
        }

    }
}