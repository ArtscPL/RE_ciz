INCLUDE globals.ink
->general
//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:หมอ #portrait:Doc

=== general ===
อย่าประมาทแผลเล็กๆเด็ดขาด ถ้าหากมีก็ต้องรักษามันให้ดีอย่าให้มีอาการแทรกซ้อน#speaker:หมอ #portrait:Doc
+ [ทำภารกิจ]
    {isS602 == true && isD602 == false: ->finish602}
    {isD602 == true && isS603 == false: ->start603}
    {isC603 == true && isD603 == false: ->finish603}
    ยังไม่มีภารกิจอะไรให้ทำในขณะนี้ ->DONE
+ [เข้าสู่ร้านค้า]
    ~Cshop = true
    [เข้าสู่ร้านขายของ]
    ->DONE
+ [เดินผ่าน]
    ไม่มีอะไรครับ ไว้มีเดี๋ยวจะแวะมาใหม่นะครับ #speaker:Player #portrait:Player
    ->DONE

=== finish602 ===
ชั้นคงไม่อาจจะให้ยากับเธอได้ทันทีเพราะว่า ชั้นไม่มียาเหลือแล้วหนะสิ#speaker:หมอ #portrait:Doc

แค่บอกวัตถุดิบที่ต้องการมาก็พอครับ เดี๋ยวผมจะรีบไปหามาให้#speaker:Player #portrait:Player

ขอชั้นตรวจสอบสภาพวัตถุดิบที่เหลือก่อนนะ ระหว่างนี้ไปเตรียมตัวมาให้พร้อมสิ#speaker:หมอ #portrait:Doc
~questTurnin = true
~isD602 = true
->DONE

=== start603 ===
อืม มีแค่วัตถุดิบชนิดเดียวที่เป็นปัญหา ที่เหลือยังพอมีอยู่ มันก็คือมอสเพลิง มอสพวกนี้จะเติบโตบนตัวของมอนสเตอร์ในเขตนี้ ชั้นต้องการ 10 ต้น ฝากด้วยหละ#speaker:หมอ #portrait:Doc

+ [ยอมรับ]
    ไว้ใจได้เลยครับ#speaker:Player #portrait:Player
    ~questAccepted = true
    ~isS603 = true
    ->DONE
+ [ปฏิเสธ]
    ตอนนี้ยังไม่พร้อม เดี๋ยวมาใหม่นะครับ#speaker:Player #portrait:Player
    ->DONE
    
=== finish603 ===
โอ้วัตถุดิบส่วนสุดท้ายมาได้ทันเวลาพอดี เอาหละรอแปปนึง#speaker:หมอ #portrait:Doc

(ผ่านไปซักครู่)#speaker:หมอ #portrait:Doc

เอาหละ เรียบร้อย เอายานี่ไปให้นักโบราณคดีซะ#speaker:หมอ #portrait:Doc
~questTurnin = true
~isD603 = true
->DONE