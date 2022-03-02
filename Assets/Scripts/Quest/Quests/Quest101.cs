using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quest101 : Quest
{
    void Start()
    {
        QuestName = "พิสูจน์ตัวตน!"; //
        description = "ยามเฝ้าเมืองไม่สามารถปล่อยให้คุณเข้าเมืองไปอย่างง่ายดาย คุณจำเป็นต้องกำจัดหมาป่าดุร้ายรอบเมืองเป็นจำนวน 10 ตัวเพื่อพิสูจน์ตัวตน";
        Todo = "กำจัดหมาป่าดุร้าย 10 ตัว";
        expReward = 50;
        recoinReward = 500;
        itemReward = null;

        Goals.Add(new KillGoal(this,1, description, Todo, false, 0, 10));

        Goals.ForEach(g => g.Init());
    }
}
