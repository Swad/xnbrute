using System;
using System.Collections.Generic;
using System.Text;

namespace XnBrute.Data
{
    /// <summary>
    /// ผลการต่อสู้ที่ถูกคำนวนจาก FightingCalculator เพื่อนำไปแสดงผล และสามารถเก็บลงดาต้าเบสเพื่อย้อนมาดูได้ด้วย
    /// </summary>
    class FightingLog
    {
        public Queue<FightingLogStep> fightingSteps = new Queue<FightingLogStep>();
    }

    class FightingLogStep
    {
        // ฝ่ายรุก
        public int actionTeamIndex;
        
        // ผู้รุก
        public List<int> actionFightersIndex = new List<int>();
        
        // ลักษณะการรุก
        public int actionTypeId;
        
        // ฝ่ายรับ
        public int reactionTeamIndex;
        
        // ผู้รับ และลักษณะการรับ
        public KeyValuePair<int, int> fighterReactionTypePairs = new KeyValuePair<int, int>();

        // คิวสเตปย่อย
        public Queue<FightingLogStep> subSteps = new Queue<FightingLogStep>();
    }
}
