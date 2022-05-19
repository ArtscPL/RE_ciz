INCLUDE globals.ink
//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:เทพทะเล #portrait:SeaGod
{isS405 == false: ->restriction}
{isS405 == true && isC405 == false: ->startFight}
{isC405 == true && isCC405 == false: ->405aftermatch}

=== restriction ===
???

ถอยด่วน เจ้านี่เก่งเกินกว่าที่นายจะรับมือได้ #speaker:อาซิลรา #portrait:Azilra
->DONE

=== startFight ===
นั่นเทพทะเลชิมิ?#speaker:Player #portrait:Player

ชิชิ#speaker:เทพทะเล #portrait:SeaGod

รับมุกเฉย?#speaker:Player #portrait:Player

ข้าก็เป็นเทพที่มีอารมณ์ขันนะ กะต้ากๆ #speaker:เทพทะเล #portrait:SeaGod

ไม่ขันแบบนี้ดิ?#speaker:Player #portrait:Player

ช่างเถอะ เทพทะเล วันนี้เราจะมากำจัดเจ้า#speaker:Player #portrait:Player

คนไร้อารมณ์ขันงั้นหรอเนี่ย แต่ก็เอาเถอะ พวกเจ้าแน่ใจเถอะว่าจะกำจัดข้าได้ ข้าหนะเป็นอมตะเชียวนะ!#speaker:เทพทะเล #portrait:SeaGod

แต่ถ้าไม่อยู่ในน้ำก็ตายได้อยู่ดีใช่ปะหละ?#speaker:Player #portrait:Player

เจ้าจะทำอะไร?#speaker:เทพทะเล #portrait:SeaGod

หึ เดี๋ยวก็รู้!#speaker:Player #portrait:Player

ตอนนี้แหละ!#speaker:อาซิลรา #portrait:Azilra
->useItem

=== useItem ===
สลากชุดหนึ่งมี 10 ใบ มีหมายเลข 1 – 10 กำกับ ความน่าจะเป็นที่จะหยิบสลากพร้อมกัน 3 ใบโดยให้แต้มรวมเป็น 10 และไม่มีสลากใบใดที่หมายเลขสูงกว่า 5 เท่ากับข้อดีต่อไปนี้

+ [1/60]
    หือ แช่แข็งทะเล เหอะเจ้าคิดเหรอว่าเจ้าจะโค่นข้าได้เมื่อแช่แข็งทะเลไปแล้วหนะ#speaker:เทพทะเล #portrait:SeaGod
    
    //change isC405 = true when defeat boss
    (ผู้เล่นจำเป็นต้องสนทนากับเทพทะเลอีกครั้งหลังจากเอาชนะได้แล้วเพื่อดำเนินเนื้อเรื่องต่อ)
    ~fightBoss = true
    ->DONE
+ [1/40]
    เผ่นด่วน! ถ้าแช่แข็งไม่ได้ สู้ชนะไปก็เปล่าประโยชน์! #speaker:อาซิลรา #portrait:Azilra
    ->DONE
+ [1/30]
    เผ่นด่วน! ถ้าแช่แข็งไม่ได้ สู้ชนะไปก็เปล่าประโยชน์! #speaker:อาซิลรา #portrait:Azilra
    ->DONE
+ [1/20]
    เผ่นด่วน! ถ้าแช่แข็งไม่ได้ สู้ชนะไปก็เปล่าประโยชน์! #speaker:อาซิลรา #portrait:Azilra
    ->DONE

=== 405aftermatch ===
เล่นแช่แข็งกันแบบนี้ นี่มันขี้โกงชัดๆ#speaker:เทพทะเล #portrait:SeaGod

ไอคนเป็นอมตะมันเอ็งนะโว้ย! ยังกล้าพูดอีกว่าโกงกัน #speaker:Player #portrait:Player

ฮะฮะฮะ ก็มีหนิ อารมณ์ขันหนะ#speaker:เทพทะเล #portrait:SeaGod

น่าเสียดายแหะ เราน่าจะเป็นเพื่อนกันได้แท้ๆ#speaker:อาซิลรา #portrait:Azilra

ช่วยไม่ได้นี่ เมื่อจะได้อะไรมาเราก็ต้องจ่ายบางสิ่งออกไป มันเป็นสัจธรรมหนะ#speaker:เทพทะเล #portrait:SeaGod

นายมีชื่อมั้ย? นายดูไม่เหมือนเป็นคนเลวเลย#speaker:Player #portrait:Player

อย่าเห็นใจอาญชากรเจ้าหนู คนผิดก็คือคนผิด ชื่อไม่สำคัญหรอก จำไว้เจ้าหนู มันมีทางออกจากโลกนี้อยู่จริงๆ กำจัดเทพอีก 2 ตนที่เหลือ แล้วเจ้าจะพบคำตอบ#speaker:เทพทะเล #portrait:SeaGod

ขอบคุณสำหรับเบาะแส ถึงพอจะเดาได้อยู่แล้วก็เถอะนะ..#speaker:Player #portrait:Player
~isCC405 = true
->DONE
