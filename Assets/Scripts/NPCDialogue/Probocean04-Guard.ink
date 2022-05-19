INCLUDE globals.ink
{isD306 == true && isS401 == false:->start401}
{isC401 == true && isD401 == false:->finish401}
->general
//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:ยาม #portrait:GuardP

=== general ===
ปราบกบฏเพื่อเมืองของเรา 
->DONE

=== start401 ===
หยุดก่อน นักผจญภัยหนุ่ม เมืองนี้กำลังอยู่ในช่วงภาระตึงเครียด พวกกบฏอาหารทะเลได้ก่อความไม่สงบทั่วทั้งผืนน้ำ คงไม่เหมาะถ้าจะให้นักผจญภัยที่ไม่รู้ที่มาเข้าเมืองในตอนนี้#speaker:ยาม #portrait:GuardP

กบฏอาหารทะเล? ซีเรียสปะนิ?#speaker:อาซิลรา #portrait:Azilra

ผมเป็นมนุษย์แล้วเราก็พึ่งมาจากเมืองฟอเรตินาเองนะครับ เราเองก็ไม่เคยเจอกบฏอาหารทะเลมาก่อนด้วย แต่แค่ได้ยินชื่อก็หิวแล้ว#speaker:Player #portrait:Player

ชื่อมันก็น่ากินอยู่ แต่นั่นไม่ใช่ประเด็น แค่ปากเปล่ามันไม่พอหรอก นายจะต้องมีหลักฐานด้วย#speaker:ยาม #portrait:GuardP

งั้นผมต้องทำยังไงถึงจะยืนยันสถานะของตัวผมได้บ้าง?#speaker:Player #portrait:Player

ง่าย ๆ เลยแค่ไปจัดการกบฏอาหารทะเลพวกนั้นไงหละ แค่ 15 ตัวก็คงพอแล้ว อะนี่ใบภารกิจ#speaker:ยาม #portrait:GuardP

+ [ยอมรับ]
    ก็ดีครับ ถือว่าเป็นการฝึกไปในตัวด้วย เดี๋ยวผมกลับมาครับ#speaker:Player #portrait:Player
    
    ~isS401 = true
    ~questAccepted = true
    ->DONE
+ [ปฏิเสธ]
    ไม่ดีกว่า เดี๋ยวผมกลับมา#speaker:Player #portrait:Player
    ->DONE 

=== finish401 ===
~questTurnin = true
~isD401 = true
ไม่เลว เท่านี้ก็ยืนยันได้แล้วว่านายไม่ได้อยู่ฝั่งเดียวกับกบฏแน่นอน เอาหละเมืองพลอโอเชียนยินดีต้อนรับ#speaker:ยาม #portrait:GuardP

ขอบคุณมากครับ แต่ผมขอถามอะไรหน่อยได้ไหมครับ?#speaker:Player #portrait:Player

ได้ทุกเรื่องแหละ ถ้าเป็นเรื่องที่รู้อะนะ#speaker:ยาม #portrait:GuardP

ถ้าไม่รู้ก็คงจะไม่ถามตั้งแต่แรกหรอกเฟ้ย!#speaker:Player #portrait:Player

อะแฮ่ม! เราได้เบาะแสมาว่า ทุก ๆ เมืองก็โดนสิ่งมีชีวิตที่เรียกตัวเองว่าเทพโจมตีหมด ผมสงสัยว่าพวกกบฏนี้ก็เป็นฝีมือของเทพที่โจมตีเมืองนี้ด้วยรึเปล่าครับ?#speaker:ยาม #portrait:GuardP

อ้อ ไอสิ่งที่เรียกตัวเองว่าเทพทะเลหนะหรอ เจ้านั่นมันกล้าโจมตีเมืองตรงๆเลยหนะเซ่ เจ้าตัวยืนยันมาเองเลยว่าไม่จำเป็นต้องใช้พวกกบฏอาหารทะเลยังไงเมืองนี้ก็ถูกทำลายอยู่ดี #speaker:ยาม #portrait:GuardP

แต่เจ้าเมืองของเราถือว่าเป็นเจ้าเมืองที่แข็งแกร่งที่สุดในบรรดาเมืองทั้งหมดเลยนะ เจ้านั่นหนะไม่คณามือหรอก โดนจัดการไปเรียบร้อยแล้ว#speaker:ยาม #portrait:GuardP

หะ..? จัดการไปแล้วหรอ ง่ายๆแบบนี้เลยเนี่ยนะ?#speaker:Player #portrait:Player

จะจริงเรอะ เทพพวกนั้นถ้าไม่มีวิธีพิเศษก็เอาพวกมันไม่ลงนะ#speaker:อาซิลรา #portrait:Azilra

โดนจัดการก็คือโดนจัดการ เอาหละพอจะบอกได้ไหมว่ามาที่เมืองนี้ทำไม? หรือมาเพราะต้องการแจ้งข่าวนี้?#speaker:ยาม #portrait:GuardP

ผมมาที่นี่เพื่อจะถามข้อมูลเกี่ยวกับเผ่ามนุษย์แล้วก็เรื่องในอดีตกับเจ้าเมืองครับ#speaker:Player #portrait:Player

งั้นก่อนเข้าเมือง เรามาพูดถึงกฎระเบียบกันก่อน ชาวเมืองของเราใช้รหัสลับในการสื่อสารกันว่าเป็นชาวเมืองจริง ๆ หรือว่าเป็นกบฏ#speaker:ยาม #portrait:GuardP

ดังนั้นนายจะต้องตอบคำถามเกี่ยวกับความน่าจะเป็นทั้งหลายที่อาจจะเกิดขึ้นในเหตุการณ์ที่ชาวเมืองยกตัวอย่างมา#speaker:ยาม #portrait:GuardP

งั้นลองทดสอบกับผมก่อนก็ได้ครับ เพื่อจะให้แน่ใจว่าชาวเมืองจะได้ไม่ไล่ตะเพิดผมออกมา#speaker:Player #portrait:Player

ดีงั้นเริ่มจาก#speaker:ยาม #portrait:GuardP
->test1

=== test1 ===
กล่องใบหนึ่งมีบัตร 5 ใบ ซึ่งเขียนหมายเลข 1,2,3,4,5 กำกับไว้ ถ้าหยิบบัตรจากกล่องใบนี้พร้อมกัน 3 ใบ จงหาความน่าจะเป็นที่ผลรวมของแต้มบนบัตรมากกว่า 10#speaker:ยาม #portrait:GuardP

+ [1/5]
    เยี่ยม งั้นข้อต่อไป#speaker:ยาม #portrait:GuardP
    ->test2
+ [2/5]
    ไหนว่าเข้าใจ?#speaker:ยาม #portrait:GuardP
    ->test1
+ [3/5]
    ไหนว่าเข้าใจ?#speaker:ยาม #portrait:GuardP
    ->test1
+ [4/5]
    ไหนว่าเข้าใจ?#speaker:ยาม #portrait:GuardP
    ->test1

=== test2 ===
มีคน 10 คน ซึ่งใน 10 คนนี้ มีขาหมูและกะเพรารวมอยู่ด้วย ถ้าจัดคน 10 คน นั่งเป็นวงกลม จงหาความน่าจะเป็นที่ขาหมูและกะเพราจะนั่งติดกัน#speaker:ยาม #portrait:GuardP
+ [1/9]
    ไหนว่าเข้าใจ?#speaker:ยาม #portrait:GuardP
    ->test2
+ [2/9]
    เอาหละ งั้นไว้เจอกันใหม่ ขอให้ได้คำตอบที่ต้องการหละ แม้แต่ชาวเมืองเขาก็ไม่ยอมบอกอะไรพวกเราเหมือนกัน#speaker:ยาม #portrait:GuardP
    ->DONE
+ [3/9]
    ไหนว่าเข้าใจ?#speaker:ยาม #portrait:GuardP
    ->test2
+ [4/9]
    ไหนว่าเข้าใจ?#speaker:ยาม #portrait:GuardP
    ->test2