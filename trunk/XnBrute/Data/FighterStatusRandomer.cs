using System;
using System.Collections.Generic;
using System.Text;

namespace XnBrute.Data
{
    class FighterStatusRandomer
    {
        /// <summary>
        /// สุ่ม FighterStatus สำหรับผู้เล่นคนใหม่
        /// </summary>
        /// <param name="fighterName"></param>
        /// <returns></returns>
        public static FighterStatus Create(string fighterName)
        {
            return new FighterStatus();
        }

        /// <summary>
        /// ทำการอัพเกรด FighterStatus ของตัวละครที่เลเวลอัพ
        /// </summary>
        /// <param name="fighterStatus"></param>
        public static void LevelUp(FighterStatus fighterStatus)
        {
        }
    }
}
