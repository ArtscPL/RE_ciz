INCLUDE globals.ink
{isD406 == true && isS501 == false: ->start501}
{isD503 == true && isS504 == false: ->start504}
{isC504 == true && isD504 == false: ->finish504}
{isD505 == true && isS506 == false:->start506}
{isC506 == true && isD506 == false: ->finish506}
.

ยินดีต้อนรับสู่เมืองคาเวกตาร์#speaker:เจ้าเมือง #portrait:LordCa
->DONE
//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:เจ้าเมือง #portrait:LordCa

=== start501 ===
ในฐานะเจ้าเมือง ข้าขอยินดีต้อนรับสู่เมืองคาเวกตาร์อย่างเป็นทางการ#speaker:เจ้าเมือง #portrait:LordCa

ขอบคุณมากครับ พ่อของท่านคิดถึงท่านมากนะท่านเจ้าเมือง#speaker:Player #portrait:Player

… เซนเทรียนา เป็นยังไงบ้างตอนนี้?#speaker:เจ้าเมือง #portrait:LordCa

หลังจากกำจัดมอนสเตอร์รอบๆทุกอย่างก็ดูสงบขึ้นมากเลยครับ #speaker:Player #portrait:Player

งั้นเจ้าก็ยังไม่รู้เรื่องสินะ#speaker:เจ้าเมือง #portrait:LordCa

เอ่อ..? เรื่องอะไรครับ?#speaker:Player #portrait:Player

ความสงบนั้นเป็นเพียงแค่ภาพลวงตาเท่านั้นแหละ คงเคยไปที่เมืองฟอเรตินามาแล้วใช่มั้ย พวกเราเป็นเผ่าไม้ที่เดินทางออกมาจากเมืองฟอเรตินาหนะ#speaker:เจ้าเมือง #portrait:LordCa

ใช่ครับ เป็นเมืองที่สามที่ได้ไปเยือน#speaker:Player #portrait:Player

ไม่สงสัยบ้างเรอะว่าทำไมเผ่าไม้ที่แก่ขนาดนั้นถึงไม่มีร่องรอยของการกลายร่างเป็นต้นไม้เลยหละ?#speaker:เจ้าเมือง #portrait:LordCa

ที่จริงแล้วเขาสามารถกวาดล้างมอนสเตอร์ทุกตัวรอบๆเมืองให้หมดไปได้ แต่เขาเลือกที่จะไม่ทำ#speaker:เจ้าเมือง #portrait:LordCa

เอ๋? ทำไมหรอครับ?#speaker:Player #portrait:Player

เอ่อ ไว้ค่อยเล่าทีหลังดีกว่า เดี๋ยวข้าจะสอนกฎภายในเมืองนี้ให้#speaker:เจ้าเมือง #portrait:LordCa

พูดให้อยากแล้วจากไปเฉยเลย!?#speaker:Player #portrait:Player

โทษทีๆ ข้าไม่สะดวกที่จะบอกเจ้าตอนนี้จริงๆ ที่จำเป็นสำหรับเจ้ามากกว่าก็คือการเรียนรู้กฎมากกว่า เพราะว่าถ้าหากไม่เข้าใจกฎนี้ พวกเราจะไม่คุยด้วยหรอกนะ#speaker:เจ้าเมือง #portrait:LordCa

อ่อ. เข้าใจละว่าทำไมคนนอกถึงคิดว่าคนเมืองนี้ไม่ต้อนรับคนนอก#speaker:Player #portrait:Player

(อธิบายกฏของเมืองให้ฟัง)#speaker:เจ้าเมือง #portrait:LordCa

นี่มัน..กฏและสมบัติของความน่าจะเป็นไม่ใช่เรอะ?#speaker:Player #portrait:Player

แสดงว่าเจ้าเข้าใจกฏของเมืองนี้แล้วใช่มั้ย?#speaker:เจ้าเมือง #portrait:LordCa

ไม่ ไม่อยากเข้าใจอะไรทั้งนั้น!!!!!#speaker:Player #portrait:Player

เอาหละ ข้าจะเป็นคนทดสอบเจ้าเอง#speaker:เจ้าเมือง #portrait:LordCa

ก็บอกว่าไม่อยากเข้าใจไงฟะ!??#speaker:Player #portrait:Player
->test1

=== test1 ===
คำถามแรก กําหนดให้ A และ B เป็นเหตุการณ์ในแซมเปิลสเปซซึ่ง P(A) = 0.5 , P(B) = 0.3
 และ P(A – B) = 0.3 แล้วจงหา P(A intersect B)#speaker:เจ้าเมือง #portrait:LordCa

+ [0.2]
    ->test2
+ [0.3]
    ไหนว่าเข้าใจไง?#speaker:เจ้าเมือง #portrait:LordCa
    ->test1
+ [0.6]
    ไหนว่าเข้าใจไง?#speaker:เจ้าเมือง #portrait:LordCa
    ->test1
+ [0.8]
    ไหนว่าเข้าใจไง?#speaker:เจ้าเมือง #portrait:LordCa
    ->test1


=== test2 ===
ยังมีอีกข้อ กําหนดให้ A และ B เป็นเหตุการณ์ในแซมเปิลสเปซซึ่ง P(A) = 0.5 , P(B) = 0.3
 และ P(A – B) = 0.3 แล้วจงหา P(A union B)#speaker:เจ้าเมือง #portrait:LordCa

+ [0.2]
    เกือบดีแล้ว#speaker:เจ้าเมือง #portrait:LordCa
    ->test2
+ [0.3]
    เกือบดีแล้ว#speaker:เจ้าเมือง #portrait:LordCa
    ->test2
+ [0.6]
    ->continue501
+ [0.8]
    เกือบดีแล้ว#speaker:เจ้าเมือง #portrait:LordCa
    ->test2


=== continue501 ===
~questTurnin = true
~isS501 = true
ก็จำได้หนิ ไม่เลวๆ#speaker:เจ้าเมือง #portrait:LordCa

ปล่อยผมปายยยย ว่าแต่พอจะรู้ไหมครับว่านักโบราณคดีอยู่ไหน?#speaker:Player #portrait:Player

ไม่รู้หรอก ไปถามยามดิ เขารู้นะ#speaker:เจ้าเมือง #portrait:LordCa

อ่าวแต่เขาไม่บอก#speaker:Player #portrait:Player

เจ้าไม่ได้ถามมากกว่า ฮ่าๆ#speaker:เจ้าเมือง #portrait:LordCa
->DONE

=== start504 ===
มาต่อจากที่เราค้างคากันไว้ละกัน จริงๆแล้วท่านพ่อนั้นมีความผิดปกติบางอย่างทำให้เกิดกลายกลายพันธุ์ โดยความพิเศษที่ได้มาจากการกลายพันธุ์ก็คือความไม่แก่ตาย#speaker:เจ้าเมือง #portrait:LordCa

ก็เป็นเรื่องที่ดีหนิครับ แต่มันเป็นไปได้ด้วยหรอครับ ไม่แก่ตายเนี่ย?#speaker:Player #portrait:Player

ถูกแล้ว ไม่มีอะไรที่ได้มาโดยไม่มีค่าตอบแทน ความสามารถนี้แลกมาด้วยการต้องดูดซึมซากศพของนักผจญภัยที่เสียชีวิตในบริเวณรอบเมือง#speaker:เจ้าเมือง #portrait:LordCa

งั้นนี่ก็คือเหตุผลที่พ่อของท่านเจ้าเมืองไม่ออกไปกำจัดมอนสเตอร์ด้วยตัวเองสินะครับ#speaker:Player #portrait:Player

แต่ในฐานะของเจ้าเมืองแล้วนี่มันผิด คนเป็นเจ้าเมืองต้องคำนึงถึงความปลอดภัยของชาวเมืองสิ สุดท้ายข้าก็ทนไม่ไหวกับทัศนคติแบบนั้นของท่านพ่อแล้วก็มาสร้างเมืองขึ้นที่นี่เองยังไงหละ#speaker:เจ้าเมือง #portrait:LordCa

(เจ้าเมือง Centriana ดูเป็นคนดีแต่ที่จริงแล้วแค่อยากให้เราไปตายเรอะ!?)#speaker:Player #portrait:Player

โดยปกติแล้วข้าจะจัดเวรยามไปกำจัดมอนสเตอร์รอบๆทุกวันแต่ทว่าข้าสัมผัสได้ว่าพวกมอนสเตอร์เริ่มก้าวร้าวผิดปกติ#speaker:เจ้าเมือง #portrait:LordCa

เอ่อ..หรือว่าจะเป็นผลมาจากเทพ?#speaker:Player #portrait:Player

เทพ?#speaker:เจ้าเมือง #portrait:LordCa

(เล่าเรื่องทั้งหมดให้ฟัง)#speaker:Player #portrait:Player

ในตอนนี้ยังไม่อาจยืนยันได้ ข้าอยากจะไหว้วานเจ้าหน่อยเพื่อเป็นข้อแลกเปลี่ยนข้าจะช่วยเตรียมของให้เจ้าพร้อมจะไปเขตแมกมาทอสเมื่อเสร็จธุระในเมืองของข้าแล้ว#speaker:เจ้าเมือง #portrait:LordCa

เราต้องการหลักฐานยืนยัน เจ้าพอจะเข้าไปสำรวจภายในส่วนลึกของถ้ำได้หรือไม่ #speaker:เจ้าเมือง #portrait:LordCa

+ [ยอมรับ]
    ไม่มีปัญหาครับ ยังไงเราก็ต้องกำจัดเทพทุกตนอยู่แล้ว ถือว่าเป็นข้อแลกเปลี่ยนที่มีแต่ได้กับผมทั้งนั้น#speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS504 = true
    ->DONE
+ [ปฏิเสธ]
    ผมมีลางสังหรณ์แปลกๆ ขอเวลาตัดสินใจหน่อยนะครับ#speaker:Player #portrait:Player
    ->DONE

//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:เจ้าเมือง #portrait:LordCa
    
=== finish504 ===
~questTurnin = true
~isD504 = true
ทั่นเจ้าเมืองงงง เทพมันมีจริงทั่นเจ้าเมืองงง #speaker:Player #portrait:Player

อาการเป็นยังไงไหนบอกหมอซิ้#speaker:เจ้าเมือง #portrait:LordCa

(เล่าสิ่งที่เกิดขึ้น)#speaker:Player #portrait:Player

อ่อ หมอขอเสียความเสียใจด้วยนะ แต่หมอก็คงช่วยอะไรไม่ได้#speaker:เจ้าเมือง #portrait:LordCa

ผมตบมุกได้ยัง?#speaker:Player #portrait:Player

แค่กๆ  ชื่อก็บอกอยู่โต้งๆว่าเป็นเทพแห่งความมืด พกไฟฉายไปส่องไหมหละ? #speaker:เจ้าเมือง #portrait:LordCa

คำตอบดูกวนตีน แต่ก็สมเหตุสมผลนะ นี่ผมต้องไปหาช่างตีเหล็กใช่มั่ย?#speaker:Player #portrait:Player

ใช่แล้ว บอกเขาว่านี่เป็นเรื่องด่วน เขาติดหนี้ข้าอยู่ เขาจะช่วยเราได้#speaker:เจ้าเมือง #portrait:LordCa

->DONE

=== start506 ===
ยอดเยี่ยม ตอนนี้เจ้าก็ได้ไฟฉายมาเรียบร้อยแล้ว ทีนี้ก็เอาไปส่องแดรกคูล่าได้แล้ว#speaker:เจ้าเมือง #portrait:LordCa

หะ ที่นี่มีแดรกคูล่าด้วยหรอ?#speaker:Player #portrait:Player

มุกหนะมุก เอาหละ ข้าขออวยพรให้เจ้าได้รับชัยชนะกลับมา ฝากเมืองของเราด้วยนะเด็กน้อย#speaker:เจ้าเมือง #portrait:LordCa

+ [ยอมรับ]
    กดดันตูอีก ได้เลยไม่มีปัญหา!#speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS506 = true
    ->DONE
+ [ปฏิเสธ]
    กดดันกันงี้ ขอเวลาคิดก่อนนะ บรุยย#speaker:Player #portrait:Player
    ->DONE
    
=== finish506 ===
ขอบคุณที่ช่วยเมืองนี้ไว้นะเจ้าหนู นี่รางวัลตามที่สัญญาไว้ เกราะคุ้มกันเพลิง มันจะช่วยป้องกันเจ้าจากสภาพแวดล้อมที่โหดร้ายของเขตแมกมาทอสได้กึ่งนึง#speaker:เจ้าเมือง #portrait:LordCa

กึ่งนึง? ไม่ทั้งหมดหรอครับ?#speaker:Player #portrait:Player

ได้แค่นี้ก็แทบจะล้างตู้เก็บของเมืองอยู่ละ#speaker:เจ้าเมือง #portrait:LordCa

แต่ยังไงก็ต้องขอบคุณมากๆครับ เท่านี้ผมก็ไปหานักโบราณคดีที่นั่นได้แล้วใช่มั้ยครับ?#speaker:Player #portrait:Player

แน่นอน มอนสเตอร์ที่นั่นเวลามันโจมตีเจ้า เจ้าจะโดนสถานะผิดปกติทันที ดังนั้นเตรียมของไปให้พร้อมหละ #speaker:เจ้าเมือง #portrait:LordCa

แต่ข้าแน่ใจว่าคณะสำรวจของนักโบราณคดีมีหมออยู่ด้วย ถ้าเสบียงหมดก็ไปซื้อจากเขาเอาละกัน มีแค่นี้แหละที่อยากจะเตือนไว้ #speaker:เจ้าเมือง #portrait:LordCa

เอ้อแล้วเรื่องของท่านพ่อ ไม่ต้องคิดมากหรอก ถ้าเจ้าสามารถกำจัดต้นตอของหายนะในเขตแมกมาทอสได้ ทุกอย่างก็น่าจะดีขึ้น#speaker:เจ้าเมือง #portrait:LordCa

งั้นไว้เจอกันใหม่ครับ ได้ช่วยไว้จริงๆ ผมจะช่วยทวีปนี้แล้วก็จะกลับโลกของผมให้ได้#speaker:Player #portrait:Player
->fifthExamIntro

=== fifthExamIntro ===
ต้องขอชมว่าเจ้าทำได้ดีกว่าที่ข้าคิดเอาไว้ เท่านี้ก็เหลือเพียงแค่เทพแห่งไฟแล้ว#speaker:อาซิลรา #portrait:Azilra

หลังเทพแห่งไฟ ชั้นต้องตบนายด้วยไหม#speaker:Player #portrait:Player

ไม่หรอก เทพแห่งไฟคือเทพตนสุดท้ายที่จะเป็นศัตรูกับเจ้า ข้าในตอนนี้มีหน้าที่แค่ส่งมอบบททดสอบให้เจ้าเท่านั้น#speaker:อาซิลรา #portrait:Azilra

งั้นส่งบททดสอบรอบนี้มาเถอะ อยากกลับบ้านแล้ว#speaker:Player #portrait:Player

งั้นจัดไป!!!#speaker:อาซิลรา #portrait:Azilra
->DONE

=== question1 ===
1/5: กล่องใบหนึ่งมีลูกบอลสีแดง 3 ลูก และ สีเหลือง 2 ลูก ถ้าหยิบลูกแรกแล้วไม่ใส่คืน จงหาความน่าจะเป็นที่จะหยิบลูกบอลสีเหลืองทั้งสองลูก

+ [0.1]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~CavectarScore = CavectarScore + 1
    ->question2
+ [0.2]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2    
+ [0.5]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2
+ [0.7]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2

=== question2 ===
2/5: หมู่บ้านแห่งหนึ่งมีประชากรอาศัยอยู่ 200 ครอบครัว มีครอบครัวที่ปลูกข้าว 100 ครอบครัว ปลูกข้าวโพด 120 ครอบครัว และปลูกทั้งข้าวและข้าวโพด 40 ครอบครัว จงหาความน่าจะเป็น ที่ครอบครัวหนึ่งในหมู่บ้านจะปลูกข้าวหรือข้าวโพด
+ [0.3]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3
+ [0.5]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3
+ [0.7]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3
+ [0.9]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~CavectarScore = CavectarScore + 1
    ->question3

=== question3 ===
สถานการณ์ต่อไปนี้จะถูกใช้ตั้งแต่ข้อ 3/5 ถึง 5/5
3/5: ให้เหตุการณ์ A และ B เป็นเหตุการณ์ที่ไม่เกิดร่วมกัน และมี P(A) = 2/3 และ P(B) = 1/4 จงหา P(A intersect B’) 
+ [0]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4
+ [2/3]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~CavectarScore = CavectarScore + 1
    ->question4
+ [1/4]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4
+ [1]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4

=== question4 ===
4/5: ให้เหตุการณ์ A และ B เป็นเหตุการณ์ที่ไม่เกิดร่วมกัน และมี P(A) = 2/3 และ P(B) = 1/4 จงหา P(A’ intersect B) 
+ [0]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5
+ [2/3]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5
+ [1/4]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~CavectarScore = CavectarScore + 1
    ->question5
+ [1]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5

=== question5 ===
5/5: ให้เหตุการณ์ A และ B เป็นเหตุการณ์ที่ไม่เกิดร่วมกัน และมี P(A) = 2/3 และ P(B) = 1/4 จงหา P(A’ union B’) 
+ [0]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate
+ [2/3]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate
+ [1/4]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate
+ [1]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~CavectarScore = CavectarScore + 1
    ->Evaluate

=== Evaluate ===
เจ้าได้ {CavectarScore}/5 คะแนน #speaker:อาซิลรา #portrait:Azilra
{
- CavectarScore < 3: ->BadGrade
- CavectarScore >= 3: ->GoodGrade
}
->DONE


//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra

=== BadGrade ===
เจ้าทำได้แค่นี้งั้นเรอะ!? ผ่านมากี่เมืองแล้ว? อย่าหวังเลยว่าจะออกไปจากช่วงเวลานี้ได้ จงติดอยู่ในวังวนอันไร้สิ้นสุดนี้เถอะ เจ้ามนุษย์ #speaker:อาซิลรา #portrait:Azilra
->DONE

=== GoodGrade ===
~questTurnin = true
~isD506 = true
เยี่ยม เท่านี้เจ้าก็มีคุณสมบัติเพียงพอแล้ว #speaker:อาซิลรา #portrait:Azilra

คุณสมบัติอะไร? #speaker:Player #portrait:Player

ไว้เจอกันเจ้ามนุษย์ ครั้งหน้าจะเป็นครั้งสุดท้ายที่เราจะได้เจอกัน#speaker:อาซิลรา #portrait:Azilra
->DONE