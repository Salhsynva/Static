using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Student
    {
        public Student(string fullname, string groupNo, byte age )
        {
            Fullname = fullname;
            GroupNo = groupNo;
            Age = age;
        }
        string _fullname;
        string _groupNo;
        public string Fullname { get => _fullname; set { if (CheckFullname(value)) _fullname = value; } }
        public string GroupNo { get => _groupNo; set { if(CheckGroupNo(value)) _groupNo = value; } }
        public byte Age { get; set; }

        public static bool CheckGroupNo(string groupno)
        {
            if (!string.IsNullOrWhiteSpace(groupno) && groupno.Length == 4)
            {
                if (char.IsUpper(groupno[0]) && char.IsDigit(groupno[1]) && char.IsDigit(groupno[2]) && char.IsDigit(groupno[3]))
                {
                    if (groupno[1] != '0')
                        
                        return true;
                }
            }
            return false;
        }

        public static bool CheckFullname(string value)
        {
            if (!string.IsNullOrWhiteSpace(value) && value.Contains(" "))
            {
                string[] fullnameArr = value.Split(' ');
                foreach (var word in fullnameArr)
                {
                    if (char.IsUpper(word[0]))
                    {
                        for (int i = 1; i < word.Length; i++)
                        {
                            if (!(char.IsLetter(word[i]) && char.IsLower(word[i])))
                            {
                                return false;
                            }
                        }
                    }
                    else
                        return false;
                }
                return true;
            }
            return false;

        }

        public void GetInfo()
        {
            Console.WriteLine($"telebenin adi ve soyadi: {Fullname} - telebenin yasi: {Age} - telebenin qrup nomresi: {GroupNo}");
        }


    }
}
