INCLUDE globals.ink

//-> finish103
{isS103 == true && isD103 == false: ->finish103 | ->general}

//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
่//#speaker:ยาม2 #portrait:Guard2

=== finish103 ===
~questTurnin = true
มีธุระอะไรหละรึเปล่าท่านนักผจญภัยหน้าใหม่? #speaker:ยาม2 #portrait:Guard2
คุณปู่ร้านขายยาฝากนํ้ายาฟื้นฟูมาให้ครับ  #speaker:Player #portrait:Player
เอ๋? คุณพ่อหนะเหรอ? ทุกวันนี้ก็ทำกำไรไม่ค่อยได้ไม่ใช่เหรอ ทำไมถึงเอามาให้ชั้นหละ? #speaker:ยาม2 #portrait:Guard2
คุณปู่เป็นห่วงพี่ยามหนะครับ ช่วงนี้หมาป่าออกอาละวาด พี่ยามก็น่าจะลำบากมากเลยใช่ไหมหละ #speaker:Player #portrait:Player
... พูดไม่ออกเลยแหละ ขอบคุณมาก ๆ นะ ถ้ามีอะไรที่พอจะช่วยได้ชั้นก็จะช่วยเต็มที่เลย #speaker:ยาม2 #portrait:Guard2
อันที่จริงก็มีอยู่แหละครับ ผมมีธุระจะไปคุยกับเจ้าเมืองหนะครับ #speaker:Player #portrait:Player
ท่านเจ้าเมืองหรอ? อืมถ้าเป็นชั้นก็คงจะลำบากเพราะไม่ได้เจอเขาบ่อยๆหนะ แต่ก็มีทางอยู่นะ #speaker:ยาม2 #portrait:Guard2
เอ๋? ผมต้องทำยังไงบ้างหรอครับ #speaker:Player #portrait:Player
ท่านเจ้าเมืองสนิทกับหัวหน้าของชั้นที่สุดแล้วหละ พวกเขามักจะพูดคุยกันเป็นประจำ  #speaker:ยาม2 #portrait:Guard2
เอ่อ แล้วท่านหัวหน้าที่ว่านั่นอยู่ที่ไหนหรอครับ? #speaker:Player #portrait:Player
เขาก็อยู่ในเมืองนั่นแหละ คอยสั่งการยามรักษาการและดูแลความเรียบร้อยภายในเมือง #speaker:ยาม2 #portrait:Guard2
ขอบคุณสำหรับข้อมูลมากๆครับ ไว้เจอกันนะครับพี่สาว #speaker:Player #portrait:Player
~isD103 = true
->DONE

=== general ===
??? #speaker:Player #portrait:Player
ยินดีต้อนรับสู่เมืองแห่งการค้าขาย #speaker:ยาม2 #portrait:Guard2
->DONE
