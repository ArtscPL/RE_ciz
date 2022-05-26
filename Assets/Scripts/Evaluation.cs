using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Evaluation : MonoBehaviour
{
    public GameObject EvaluationUI;
    public Text text1;
    public Text text2;
    public Text text3;
    public Text text4;
    public Text text5;
    public void GetEvaluate(){
        if(EvaluationUI.activeSelf){
            EvaluationUI.SetActive(false);
            return;
        }
        else{
            EvaluationUI.SetActive(true);
        }
        int CScore = ((Ink.Runtime.IntValue)DialogueManager
            .GetInstance()
            .GetVariableState("CentrianaScore")).value;
        int SScore = ((Ink.Runtime.IntValue)DialogueManager
            .GetInstance()
            .GetVariableState("SlopakiaScore")).value;
        int FScore = ((Ink.Runtime.IntValue)DialogueManager
            .GetInstance()
            .GetVariableState("ForetinaScore")).value;
        int PScore = ((Ink.Runtime.IntValue)DialogueManager
            .GetInstance()
            .GetVariableState("ProboceanScore")).value;
        int CaScore = ((Ink.Runtime.IntValue)DialogueManager
            .GetInstance()
            .GetVariableState("CavectarScore")).value;
        int CraftSuc = Character.GetInstance().CraftEquip;
        int ChestSuc = Character.GetInstance().ChestUnlocked;
        int progress = PlayerOwnQuest.GetInstance().QuestIDTracking;
        text1.text = "ผลการประเมิณของคุณอยู่ในระดับ:";
        text2.text = "ผลการประเมิณของคุณอยู่ในระดับ:";
        text3.text = "ผลการประเมิณของคุณอยู่ในระดับ:";
        text4.text = "ผลการประเมิณของคุณอยู่ในระดับ:";
        text5.text = "ผลการประเมิณของคุณอยู่ในระดับ:";

        //centriana
        if(CScore<8 && ChestSuc < 1 && progress == 0){
            text1.text += "Unlisted (ระบบยังไม่สามารถวัดระดับของคุณได้) \nคุณจำเป็นสร้างความคืบหน้าในเกมเพื่อที่เราจะได้วัดระดับคุณได้อย่างถูกต้อง";            
        }
        else if(CScore<8 && (ChestSuc != 0 || progress > 0)){
            text1.text += "Beginner (คุณมีความเข้าใจพื้นฐานเกี่ยวกับเรื่องหลักการนับ)\nคุณสามารถทำภารกิจและแก้ไขกล่องปริศนาเพิ่มเติม เพื่อเพิ่มระดับการประเมิณของคุณได้";
        }
        else if(CScore>=8){
            if(CScore < 10)
            text1.text += "Intermediate (คุณสามารถแก้โจทย์ปัญหาระดับยากในเรื่องหลักการนับได้แล้ว)";
            else if(CScore == 10 && ChestSuc >= 4)
            text1.text += "Nerd (คุณสามารถตอบคำถามได้ทุกข้อในบททดสอบของเรา คุณไม่น่ามีปัญหากับเรื่องนี้อีกแล้ว)";
            else
            text1.text += "Pro (คุณทำบททดสอบสุดท้ายได้คะแนนเต็ม)\nแต่คุณสามารถเพิ่มระดับได้ด้วยการแก้ไขกล่องปริศนาทั้งหมดในแผนที่เซนเทรียนา";
        }

        //slopakia
        if(progress<201){
            text2.text += "Unlisted (ระบบยังไม่สามารถวัดระดับของคุณได้) \nคุณจำเป็นสร้างความคืบหน้าในเกมเพื่อที่เราจะได้วัดระดับคุณได้อย่างถูกต้อง";
        }
        else if(progress>=201){
            if(SScore<3){
                text2.text += "Beginner (คุณมีความเข้าใจพื้นฐานเกี่ยวกับการเรียงสับเปลี่ยน)\nคุณสามารถทำภารกิจและแก้ไขกล่องปริศนาเพิ่มเติม เพื่อเพิ่มระดับการประเมิณของคุณได้";
            }
            else if(SScore >=3 && SScore < 5)
                text2.text += "Intermediate (คุณสามารถแก้โจทย์ปัญหาระดับยากในเรื่องการเรียงสับเปลี่ยนได้แล้ว)";
            else if(SScore == 5 && ChestSuc >= 7){
                text2.text += "Nerd (คุณสามารถตอบคำถามได้ทุกข้อในบททดสอบของเรา คุณไม่น่ามีปัญหากับเรื่องนี้อีกแล้ว)";
            }
            else if(SScore==5 && ChestSuc <7)
            text2.text += "Pro (คุณทำบททดสอบสุดท้ายได้คะแนนเต็ม)\nแต่คุณสามารถเพิ่มระดับได้ด้วยการแก้ไขกล่องปริศนาทั้งหมดในแผนที่สโลปาเคียร์";
        }

        //foretina
        if(progress<301){
            text3.text += "Unlisted (ระบบยังไม่สามารถวัดระดับของคุณได้) \nคุณจำเป็นสร้างความคืบหน้าในเกมเพื่อที่เราจะได้วัดระดับคุณได้อย่างถูกต้อง";
        }
        else if(progress>=301){
            if(FScore<3){
                text3.text += "Beginner (คุณมีความเข้าใจพื้นฐานเกี่ยวกับการจัดหมู่)\nคุณสามารถทำภารกิจและแก้ไขกล่องปริศนาเพิ่มเติม เพื่อเพิ่มระดับการประเมิณของคุณได้";
            }
            else if(FScore >=3 && FScore < 5)
                text3.text += "Intermediate (คุณสามารถแก้โจทย์ปัญหาระดับยากในเรื่องการจัดหมู่ได้แล้ว)";
            else if(FScore == 5 && ChestSuc >= 10){
                text3.text += "Nerd (คุณสามารถตอบคำถามได้ทุกข้อในบททดสอบของเรา คุณไม่น่ามีปัญหากับเรื่องนี้อีกแล้ว)";
            }
            else if(FScore==5 && ChestSuc <10)
            text3.text += "Pro (คุณทำบททดสอบสุดท้ายได้คะแนนเต็ม)\nแต่คุณสามารถเพิ่มระดับได้ด้วยการแก้ไขกล่องปริศนาทั้งหมดในแผนที่ฟอเรตินา";
        }

        //probocean
        if(progress<401){
            text4.text += "Unlisted (ระบบยังไม่สามารถวัดระดับของคุณได้) \nคุณจำเป็นสร้างความคืบหน้าในเกมเพื่อที่เราจะได้วัดระดับคุณได้อย่างถูกต้อง";
        }
        else if(progress>=401){
            if(PScore<8){
                text4.text += "Beginner (คุณมีความเข้าใจพื้นฐานเกี่ยวกับความน่าจะเป็น)\nคุณสามารถทำภารกิจและแก้ไขกล่องปริศนาเพิ่มเติม เพื่อเพิ่มระดับการประเมิณของคุณได้";
            }
            else if(PScore >=8 && PScore < 10)
                text4.text += "Intermediate (คุณสามารถแก้โจทย์ปัญหาระดับยากในเรื่องความน่าจะเป็นได้แล้ว)";
            else if(PScore == 10 && ChestSuc >= 14){
                text4.text += "Nerd (คุณสามารถตอบคำถามได้ทุกข้อในบททดสอบของเรา คุณไม่น่ามีปัญหากับเรื่องนี้อีกแล้ว)";
            }
            else if(PScore==10 && ChestSuc <14)
            text4.text += "Pro (คุณทำบททดสอบสุดท้ายได้คะแนนเต็ม)\nแต่คุณสามารถเพิ่มระดับได้ด้วยการแก้ไขกล่องปริศนาทั้งหมดในแผนที่พลอโบเชียน";
        }

        //cavectar
        if(progress<501){
            text5.text += "Unlisted (ระบบยังไม่สามารถวัดระดับของคุณได้) \nคุณจำเป็นสร้างความคืบหน้าในเกมเพื่อที่เราจะได้วัดระดับคุณได้อย่างถูกต้อง";
        }
        else if(progress>=501){
            if(CaScore<3){
                text5.text += "Beginner (คุณมีความเข้าใจพื้นฐานเกี่ยวกับกฏและสมบัติของความน่าจะเป็น)\nคุณสามารถทำภารกิจและแก้ไขกล่องปริศนาเพิ่มเติม เพื่อเพิ่มระดับการประเมิณของคุณได้";
            }
            else if(CaScore >=3 && CaScore < 5)
                text5.text += "Intermediate (คุณสามารถแก้โจทย์ปัญหาระดับยากในเรื่องกฏและสมบัติของความน่าจะเป็นได้แล้ว)";
            else if(CaScore == 5 && ChestSuc >= 17){
                text5.text += "Nerd (คุณสามารถตอบคำถามได้ทุกข้อในบททดสอบของเรา คุณไม่น่ามีปัญหากับเรื่องนี้อีกแล้ว)";
            }
            else if(CaScore==5 && ChestSuc <17)
            text5.text += "Pro (คุณทำบททดสอบสุดท้ายได้คะแนนเต็ม)\nแต่คุณสามารถเพิ่มระดับได้ด้วยการแก้ไขกล่องปริศนาทั้งหมดในแผนที่คาเวกตาร์";
        }
    }
}
