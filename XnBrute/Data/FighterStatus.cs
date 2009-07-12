using System;
using System.Collections.Generic;
using System.Text;

namespace XnBrute.Data
{
    /// <summary>
    /// ข้อมูลต่างๆของตัวละครแต่ละตัว รวมถึงหน้าตาด้วย ข้อมูลนี้จะถูกโหลดจากดาต้าเบส
    /// </summary>
    class FighterStatus
    {
        public string fighterName;
        public int fighterLevel;

        public int agility; // การหลบหลีก การโจมตีก่อน 
        public int strength; // พลังโจมตี
        public int vitality; // พลังป้องกัน
        public int dexterity; // ความชำนาญในการใช้สกิล
        public int friendly; // การร่วมมือ

        public int hp;
        public int mp;
    }
}
