INCLUDE globals.ink
->general
//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:ช่างตีเหล็ก #portrait:BlackCa

=== general ===
~questAccepted = false
~Cshop = false
~Ccraft = false
มีงานอะไรให้ทำมั้ย? ข้าอยากมีงานทำ#speaker:ช่างตีเหล็ก #portrait:BlackCa

+ [ทำภารกิจ]
    {isD504 == true && isS505 == false:->start505}
    {isC505 == true && isD505 == false: ->finish505}
    ขณะนี้ยังไม่มีภารกิจที่สามารถทำได้#speaker:ช่างตีเหล็ก #portrait:BlackCa
    ->DONE
+ [สร้างอุปกรณ์]
    ~Ccraft = true
    [เข้าสู่กระบวนการสร้างอุปกรณ์]
    ->DONE
+ [เดินผ่าน]
    ไม่มีอะไรครับ ไว้มีเดี๋ยวจะมาหานะครับ #speaker:Player #portrait:Player
    ->DONE
    
=== start505 ===
เรื่องด่วนเรอะ? อยากได้อะไรที่มันลบล้างพลังของเทพแห่งความมืดด้วยสินะ ไม่มีปัญหา #speaker:ช่างตีเหล็ก #portrait:BlackCa

แต่ต้องตอบคำถามมาก่อนนะ#speaker:ช่างตีเหล็ก #portrait:BlackCa

ตะแต่... นี่เป็นเรื่องด่วนนะ?#speaker:Player #portrait:Player

สถานการณ์คือ...#speaker:ช่างตีเหล็ก #portrait:BlackCa

ไม่ฟังกันซะงั้น?#speaker:Player #portrait:Player

กำหนดให้ A และ B เป็นเหตุการณ์ใน Sample Space ซึ่ง P(A) = 3/5, P(B) = 2/5 และ P(A intersect B) = 1/5 จงหา P(A intersect B’)#speaker:ช่างตีเหล็ก #portrait:BlackCa

+ [1/5]
    ไม่ไหว ๆ เรื่องด่วนแค่ไหนก็ไม่รับถ้าแค่นี้ยังไม่รู้#speaker:ช่างตีเหล็ก #portrait:BlackCa
    ->DONE
+ [2/5]
    ->con505
+ [3/5]
    ไม่ไหว ๆ เรื่องด่วนแค่ไหนก็ไม่รับถ้าแค่นี้ยังไม่รู้#speaker:ช่างตีเหล็ก #portrait:BlackCa
    ->DONE
+ [4/5]
    ไม่ไหว ๆ เรื่องด่วนแค่ไหนก็ไม่รับถ้าแค่นี้ยังไม่รู้#speaker:ช่างตีเหล็ก #portrait:BlackCa
    ->DONE

=== con505 ===
เค กลับมาคุยเรื่องธุรกิจกัน#speaker:ช่างตีเหล็ก #portrait:BlackCa

ไปหาหางค้างคาวยักษ์มาซัก 15 ชิ้นกับแร่ส่องประกาย 10 ก้อน หาได้จากค้างคาวยักษ์นั่นแหละ #speaker:ช่างตีเหล็ก #portrait:BlackCa

สรุปคือไปตบค้างคาวยักษ์มา 15 ตัวสินะ#speaker:อาซิลรา #portrait:Azilra

+ [ยอมรับ]
    ได้ครับ เดี๋ยวจะรีบกลับมา อุ่นเตาไว้ก่อนเลย#speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS505 = true
    ->DONE
+ [ปฏิเสธ]
    เอ่อ... งานนี้ไม่ด่วนก็ได้ ขอเตรียมใจก่อน#speaker:Player #portrait:Player
    ->DONE

=== finish505 ===
~questTurnin = true
~isD505 = true
ยอดเยี่ยม เท่านี้ก็ได้ของที่เราต้องการแล้ว#speaker:ช่างตีเหล็ก #portrait:BlackCa

(ผ่านไปซักพัก)#speaker:ช่างตีเหล็ก #portrait:BlackCa

เอ้านี่ รับแหวนรัศมีเทพไป มันมีพลังที่จะลบล้างพลังแห่งความมืดได้ในระยะเวลาสั้นๆ กลับไปหาไอหนูเจ้าเมืองซะแล้วบอกว่าข้าไม่ได้ติดหนี้อะไรเขาแล้ว #speaker:ช่างตีเหล็ก #portrait:BlackCa

ขอบคุณมากครับ#speaker:Player #portrait:Player
->DONE