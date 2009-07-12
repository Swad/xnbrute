using System;
using System.Collections.Generic;
using System.Text;
using XnBrute.Data;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace XnBrute.Visualization
{
    /// <summary>
    /// ใช้สำหรับแสดงผลการต่อสู้จาก FightingLog 
    /// </summary>
    class FightingLogDisplayer
    {
        FightingLogStep mainStep;
        FightingLogStep subStep;
        FightingLog log;
        DrawingContext draw;

        /// <summary>
        /// สร้างโรงฉาย โดยรับผลการต่อสู้ที่ผ่านการคำนวนแล้วมา เพื่อโหลดของที่จะใช้วาด เช่น ฉากหลัง, ตัวละคร, อาวุธ และ อื่นๆ
        /// </summary>
        /// <param name="fightingLog"></param>
        public FightingLogDisplayer(FightingLog fightingLog, DrawingContext context)
        {
            this.log = fightingLog;
            this.draw = context;
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
            if (HasNextMainStep)
            {
                NextMainStep();
            }
        }

        int mainStepIndex = -1;
        private void NextMainStep()
        {
            mainStep = log.fightingSteps.Dequeue();
            timeCount = timeOut;
            subStepIndex = -1;
            mainStepIndex++;
        }

        int subStepIndex = -1;
        private void NextSubStep()
        {
            subStep = mainStep.subSteps.Dequeue();
            timeCount = timeOut;
            subStepIndex++;
        }

        private bool HasNextMainStep
        {
            get { return log.fightingSteps.Count > 0; }
        }

        private bool HasNextSubStep
        {
            get { return mainStep.subSteps.Count > 0; }
        }

        bool isFinished;
        private void OnFinish()
        {
            isFinished = true;
            if (Finished != null)
                Finished(this);
        }

        float timeCount = 0;
        float timeOut = 1;
        public void Update(GameTime gameTime)
        {
            if (!isFinished)
            {
                timeCount -= (float)gameTime.ElapsedGameTime.TotalSeconds;
                if (timeCount <= 0)
                {
                    if (HasNextSubStep)
                    {
                        NextSubStep();
                    }
                    else if (HasNextMainStep)
                    {
                        NextMainStep();
                    }
                    else
                    {
                        OnFinish();
                    }
                }
            }
        }

        public void Draw(GameTime gameTime)
        {
            draw.spriteBatch.Begin();

            string text = isFinished ? "Finished" : "Step : " + mainStepIndex + " Sub Step : " + subStepIndex;
            draw.spriteBatch.DrawString(draw.font1, text, new Vector2(100), Color.White);
    
            draw.spriteBatch.End();
        }
    }
}
