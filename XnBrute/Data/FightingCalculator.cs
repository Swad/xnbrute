using System;
using System.Collections.Generic;
using System.Text;

namespace XnBrute.Data
{
    class FightingCalculator
    {
        /// <summary>
        /// คำนวนผลการต่อสู้ระหว่าง FighterStatus ของผู้เล่นสองคน ได้ผลลัพธ์เป็น FightingLog เอาไว้สร้าง FightingLogDisplayer สำหรับแสดงผล
        /// </summary>
        /// <param name="fighter1">สถานะของผู้เล่นคนแรก</param>
        /// <param name="fighter2">สถานะของผู้เล่นคนที่สอง</param>
        /// <returns>ผลการต่อสู้</returns>
        public static FightingLog Calculate(FighterStatus fighter1, FighterStatus fighter2)
        {
            return new FightingLog();
        }
    }
}
