using System;
using System.Collections.Generic;
using System.Text;

namespace XnBrute.Data
{
    class FightingCalculator
    {
        /// <summary>
        /// คำนวนผลการต่อสู้ระหว่าง FighterStatus ของผู้เล่นสองทีม ได้ผลลัพธ์เป็น FightingLog เอาไว้สร้าง FightingLogDisplayer สำหรับแสดงผล
        /// </summary>
        /// <param name="fighter1">สถานะของผู้เล่นทีมแรก</param>
        /// <param name="fighter2">สถานะของผู้เล่นทีมที่สอง</param>
        /// <returns>ผลการต่อสู้</returns>
        public static FightingLog Calculate(List<FighterStatus> team1, List<FighterStatus> team2)
        {
            return new FightingLog();
        }
    }
}
