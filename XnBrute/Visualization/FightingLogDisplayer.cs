using System;
using System.Collections.Generic;
using System.Text;
using XnBrute.Data;
using Microsoft.Xna.Framework;

namespace XnBrute.Visualization
{
    /// <summary>
    /// ใช้สำหรับแสดงผลการต่อสู้จาก FightingLog 
    /// </summary>
    class FightingLogDisplayer
    {
        /// <summary>
        /// สร้างโรงฉาย โดยรับผลการต่อสู้ที่ผ่านการคำนวนแล้วมา เพื่อโหลดของที่จะใช้วาด เช่น ฉากหลัง, ตัวละคร, อาวุธ และ อื่นๆ
        /// </summary>
        /// <param name="fightingLog"></param>
        public FightingLogDisplayer(FightingLog fightingLog)
        {
        }

        /// <summary>
        /// อีเว้นที่จะถูกเรียกเมื่อฉายจบแล้ว
        /// </summary>
        public event Action<FightingLogDisplayer> Finished;

        /// <summary>
        /// สั่งให้เริ่มแสดงผลการต่อสู้ได้
        /// </summary>
        public void Play()
        {
        }

        public void Update(GameTime gameTime)
        {
        }

        public void Draw(GameTime gameTime)
        {
        }
    }
}
