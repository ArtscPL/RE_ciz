INCLUDE globals.ink

//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
{isS201 == true && (isC201 == false && isD201 == false): ->progress201 | ->general}

=== general ===
กล่องปริศนาพิเศษ ต้องมีภารกิจจากยามแห่งเมืองสโลปาเคียร์เท่านั้นถึงจะเปิดได้
->DONE

=== progress201 ===
นี่น่าจะเป็นกล่องปริศนาที่พี่ยามพูดถึงสินะ ไม่เห็นจะมีเบาะแสของทีมตรวจสอบก่อนหน้านี้เลยซักนิด #speaker:Player #portrait:Player

งั้นก็ลองเปิดกล่องนี่ดูก่อนเถอะ หลังจากนี้ค่อยไปบอกยามตามตรงก็ได้ว่าไม่มีอะไรเลย  #speaker:อาซิลรา #portrait:Azilra


->unlocking

=== unlocking ===
มีกุญแจอยู่ 5 ดอก หากต้องการวางกุญแจทั้งหมดให้เรียงต่อกันเป็นระเบียบในแนวตรง จะมีวิธีจัดกี่วิธี?

+ [30]
    ดูเหมือนจะไม่ใช่อันนี้แหะ #speaker:Player #portrait:Player
    ->unlocking
+ [60]
    ดูเหมือนจะไม่ใช่อันนี้แหะ #speaker:Player #portrait:Player
    ->unlocking
+ [120]
    ->progress201_2
+ [180]
    ดูเหมือนจะไม่ใช่อันนี้แหะ #speaker:Player #portrait:Player
    ->unlocking


=== progress201_2 ===
เอ๊ะ เปิดแล้ว! ว่าแต่นี่มันสร้อยคออะไรเนี่ย? ดูแล้วไม่น่าจะมาอยู่ในกล่องนี้ได้เลย #speaker:Player #portrait:Player

เห็นด้วยเลย ดูธรรมดามากๆ ดูเหมือนจะเป็นของต่างหน้ามากกว่า  #speaker:อาซิลรา #portrait:Azilra

งั้นลองเอาไปถามพี่ยามกัน บางทีถ้าไม่ใช่ของต่างหน้าของเจ้าของกล่องก็อาจจะเป็นของทีมตรวจตราก่อนหน้านี้ก็ได้ #speaker:Player #portrait:Player
~isC201 = true
->DONE