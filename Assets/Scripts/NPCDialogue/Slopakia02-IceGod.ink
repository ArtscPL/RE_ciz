//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:เทพนํ้าแข็ง #portrait:IceGod
INCLUDE globals.ink

{isS207 == true && isB107 == false: ->startFight}
{isB107 == true && isC107 == false: ->finishHim}
->restriction

=== restriction ===
???

ถอยด่วน เจ้านี่เก่งเกินกว่าที่นายจะรับมือได้ #speaker:อาซิลรา #portrait:Azilra
->DONE

=== startFight ===
เทพน้ำแข็ง วันนี้นายจะต้องจบชีวิตลงที่นี่!#speaker:Player #portrait:Player

สิ่งมีชีวิตชั้นต่ำ เจ้ากล้าขู่ข้าอย่างงั้นรึ!? ข้าจะแสดงให้เห็นเองว่าเทพไม่ใช่ตัวตนที่พวกเจ้าสามารถขัดขวางได้!#speaker:เทพนํ้าแข็ง #portrait:IceGod

จากที่ท่านเจ้าเมืองได้บอกมา ใช้พลังของธนูในการทำลายการป้องกันของมันซะ!#speaker:อาซิลรา #portrait:Azilra

เล็งอยู่ รอแปป#speaker:Player #portrait:Player
->UseBow

=== UseBow ===
[เล็งยิง] จัดธงสีขาว 3 ธง ธงสีแดง 2 ธง และธงสีนํ้าเงิน 4 ธง แขวนในแนวเส้นตรงจะเรียงสับเปลี่ยนได้ลักษณะต่าง ๆ กันได้ทั้งหมดกี่วิธี
+ [1260]
    ->realfightstart
+ [960]
    ยิงให้มันแม่นกว่านี้หน่อยสิฟะ!#speaker:อาซิลรา #portrait:Azilra
    ->UseBow
+ [660]
    ยิงให้มันแม่นกว่านี้หน่อยสิฟะ!#speaker:อาซิลรา #portrait:Azilra
    ->UseBow
+ [360]
    ยิงให้มันแม่นกว่านี้หน่อยสิฟะ!#speaker:อาซิลรา #portrait:Azilra
    ->UseBow
    
=== realfightstart ===
เก๋กู้ด! ยิงโดนแกนพลังงานของมันเต็มๆ เท่านี้มันก็ฟื้นฟูไม่ได้แล้ว#speaker:อาซิลรา #portrait:Azilra

เอาหละได้เวลาสู้กันจริงๆจังๆซักที#speaker:Player #portrait:Player

อย่าได้ใจเกินไปนัก ต่อให้ข้าฟื้นฟูไม่ได้ เจ้าก็เอาชนะข้าไม่ได้อยู่ดี!#speaker:เทพนํ้าแข็ง #portrait:IceGod

เดี๋ยวก็รู้#speaker:อาซิลรา #portrait:Azilra

(ผู้เล่นจำเป็นต้องสนทนากับเทพนํ้าแข็งอีกครั้งหลังเอาชนะได้แล้ว)
~fightBoss = true
//change isB207 = true when defeat boss
->DONE

=== finishHim ===
ไม่ ไม่ ไม่ ไม่!!! เป็นไปไม่ได้! นี่ข้าพ่ายแพ้ให้กับสิ่งมีชีวิตชั้นต่ำอย่างงั้นเหรอ!? ทั้งๆที่ข้าได้รับพลังมาจากท่านผู้นั้นแล้วแท้ๆ!#speaker:เทพนํ้าแข็ง #portrait:IceGod

ท่านผู้นั้น? ผู้นั้นไหน? ใช่คนเดียวกับคนที่โยนบททดสอบสวรรค์มารึเปล่า?#speaker:Player #portrait:Player

มันไม่มีชีวิตอยู่ในตอบแล้วนั่นหนะ #speaker:อาซิลรา #portrait:Azilra

นี่เรายังไม่ทันได้ข้อมูลอะไรเลยนะ!#speaker:Player #portrait:Player

ถึงนายถามไปชั้นคิดว่าเจ้านั่นก็คงไม่ตอบอยู่ดี เอาหละกลับไปหาเจ้าเมืองกันเถอะ #speaker:อาซิลรา #portrait:Azilra
~isC207 = true
->DONE