INCLUDE globals.ink
//->ForthExamIntro
{isD401 == false: ->NotReady}
{isD401 == true && isS402 == false: ->start402}
{isC402 == true && isD402 == false: ->finish402}
{isD403 == true && isS404 == false: ->start404}
{isS405 == false && isD404 == true: ->start405}
{isCC405 == true && isD405 == false: ->finish405}
{isD405 == true && isS406 == false: ->start406}
{isS406 == true:->allDone}
=== NotReady ===
.

(ผู้เล่นจำเป็นต้องทำภารกิจจากยามให้เสร็จก่อน)
->DONE

=== allDone ===
.

อยากกินซีฟู้ดจังเลยน้า#speaker:เจ้าเมือง #portrait:LordP
->DONE

=== start402 ===
มนุษย์เรอะ? ข้านึกว่าหายสาบสูญไปหมดแล้วซะอีก แต่ในเมื่อเจ้าต้องการจะเจอข้า งั้นมันก็มีอยู่แค่เรื่องเดียวหละนะ แต่เรื่องอะไรที่ข้าจะบอกเจ้าหละ?#speaker:เจ้าเมือง #portrait:LordP

ผมยินดีที่จะช่วยงานภายในเมืองครับ อะไรก็ได้เราต้องการแค่ความจริงเท่านั้น#speaker:Player #portrait:Player

อืมมมม ในเมื่อเจ้าต้องการอย่างนั้น งั้นก็เริ่มจากนี่ก่อนเลย เจ้าคงได้ยินมาจากยามแล้วว่าช่วงนี้พวกกบฏอาหารทะเลกำลังป่วนเมืองของเราอยู่ เจ้าจงไปกำราบพวกมันมาซัก 30 ตัวซะ#speaker:เจ้าเมือง #portrait:LordP

+ [ยอมรับ]
    ได้ครับ แต่อันนี้ข้อสงสัยส่วนตัว ใครเป็นคนชื่อกบฏอาหารทะเลครับ?#speaker:Player #portrait:Player
    ข้าเอง แค่ได้ยินก็หิวแล้วหละสิ วะฮะฮ่า! ไม่ว่าพวกมันจะทำอะไรสุดท้ายมันก็จบลงที่การกลายเป็นอาหารทะเลอยู่ดี#speaker:เจ้าเมือง #portrait:LordP
    ซักจะหิว ซีฟู้ด ไม่ได้กินมานานมาก#speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS402 = true
    ->DONE
+ [ปฏิเสธ]

    ->DONE
    
=== finish402 ===
~questTurnin = true
~isD402 = true

เสร็จเร็วกว่าที่คิด ไม่เลว ๆ #speaker:เจ้าเมือง #portrait:LordP

งั้นก็..#speaker:Player #portrait:Player

แต่เดี๋ยวก่อน ข้ายังไม่พอใจ#speaker:เจ้าเมือง #portrait:LordP

อ่าวเห้ย! ไม่เหมือนที่คุยกันไว้นี่นา#speaker:อาซิลรา #portrait:Azilra

ที่บอกว่าเธอจะเลือกเขาและไม่มีวันกลับมา…#speaker:Player #portrait:Player

หยุดไว้ตรงนั้น! ข้ายังมีงานอีกอย่างให้ทำ เพื่อตัวเจ้าเอง จงไปหาช่างตีเหล็กในเมืองนี้แล้วบอกให้เขาสร้างเกราะจ้าวสมุทรให้เจ้า หลังจากได้มันมาข้าจะบอกสิ่งที่ข้ารู้ให้#speaker:เจ้าเมือง #portrait:LordP

ก็ดีครับ ผมจะรีบกลับมา#speaker:Player #portrait:Player
->DONE

=== start404 ===
วะฮะฮ่า กลับมาแล้วเรอะเจ้าหนู! ทำได้ดีมาก#speaker:เจ้าเมือง #portrait:LordP

ต้มกันซะเปื่อยเลย หวังว่าท่านเจ้าเมืองที่น่าเคารพคงไม่กลับคำใช่ไหมครับ??????#speaker:Player #portrait:Player

แน่นอนๆ เราจะเริ่มยังไงดี เอาเป็นว่าในอดีตนั้นเคยมีมนุษย์อยู่เต็มไปหมด อีกทั้งมนุษย์เหล่านั้นก็ยังได้รับการดูแลจากเหล่าผู้สร้างเป็นอย่างดี #speaker:เจ้าเมือง #portrait:LordP

แต่ด้วยเรื่องอะไรข้าก็ไม่อาจรู้ได้ เหล่าผู้สร้างได้หันมาสู้กันเอง ความเสียหายมันรุนแรงมากเรียกได้ว่าเป็นสงครามล้างโลกเลยหละ #speaker:เจ้าเมือง #portrait:LordP

วันนั้นข้าว่ายน้ำเล่นอยู่เหลือบไปเห็นตอนที่พวกเขาเริ่มสู้กันพอดี ข้าก็เลยรีบอพยพคนก่อนยังไงหละ หลังจากสงครามจบมนุษย์และผู้สร้างก็หายสาบสูญไปเลย#speaker:เจ้าเมือง #portrait:LordP

เอ่อ.. เหมือนจะได้อะไร แต่ในขณะเดียวกันก็ไม่ได้อะไร... ผมแค่อยากกลับบ้านเอง.. แต่ยังไงก็ขอบคุณมากครับ#speaker:Player #portrait:Player

ขอโทษด้วยเด็กน้อย แต่ข้ารู้มาแค่นี้จริงๆ คงมีแต่ผู้สร้างเท่านั้นแหละที่จะตอบคำถามเจ้าได้..#speaker:เจ้าเมือง #portrait:LordP

ไม่มีทางอื่นเลยหรอครับ?#speaker:Player #portrait:Player

อืม อาจจะมี เดี๋ยวนะ นี่มัน… มันน่าจะตายไปแล้วนี่นา!#speaker:เจ้าเมือง #portrait:LordP

เกิดอะไรขึ้นหรอครับ?#speaker:Player #portrait:Player

เจ้าตัวที่เรียกตัวเองว่าเทพทะเลหนะสิ ข้าได้จัดการมันไปแล้วครั้งนึง แต่จู่ๆข้าก็สัมผัสได้ถึงตัวตนของมันอีกครั้ง#speaker:เจ้าเมือง #portrait:LordP

นั่นไงเทพตายยากอีกตัว#speaker:อาซิลรา #portrait:Azilra

พวกเทพถ้าไม่มีวิธีพิเศษคงจัดการไม่ได้หรอกครับ#speaker:Player #portrait:Player

อืม..ถ้าข้าเดาไม่ผิดอีกฝั่งคงจะไม่มีวันตายหากสู้กันในพื้นที่ๆมีน้ำ ลำบากละสิ เจ้าหนู ไปหาช่างตีเหล็ก ถามเขาว่ามีอะไรพอจะช่วยได้ไหม ยังไงซะอีกฝ่ายคงไม่ออกไปสู้นอกเขตทะเลแน่ๆ#speaker:เจ้าเมือง #portrait:LordP

+ [ยอมรับ]
    ไว้ใจได้เลยครับ#speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS404 = true
    ->DONE
+ [ปฏิเสธ]
    ทำแน่ครับ แต่เดี๋ยวกลับมารับอีกรอบนะครับ #speaker:Player #portrait:Player
    ->DONE

//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:เจ้าเมือง #portrait:LordP
    
=== start405 ===
เยี่ยม อุปกรณ์ก็พร้อมคนก็พร้อม รออะไรหละ ไปจัดการมันเลย#speaker:เจ้าเมือง #portrait:LordP

เอ่อ.. จะไม่ไปด้วยหรอครับ? ไม่ใช่ว่าท่านเคยโค่นเทพทะเลไปแล้วไม่ใช่หรอ มาช่วยกันอีกรอบก็ไม่น่ามีปัญหานะ#speaker:Player #portrait:Player

ไม่หละ นี่ไม่ใช่ศึกของข้าอีกต่อไป ไปซะเจ้าหนู ช่วยเมืองนี้ไว้#speaker:เจ้าเมือง #portrait:LordP

+ [ยอมรับ]
    ไว้ใจได้เลยครับ#speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS405 = true    
    ->DONE
+ [ปฏิเสธ]
    ทำแน่ครับ แต่เดี๋ยวกลับมารับอีกรอบนะครับ #speaker:Player #portrait:P    
    ->DONE
    
=== finish405 ===
~questTurnin = true
~isD405 = true
โอ้เจ้ากลับมาแล้วเด็กน้อย พอดีเลยข้าพึ่งจะนึกถึงคนบางคนที่จะช่วยเจ้าได้แล้ว#speaker:เจ้าเมือง #portrait:LordP

เอ๊ะ? จริงหรอครับ? งั้นเขาเป็นใครกัน?#speaker:Player #portrait:Player

อย่างแรกข้าก็ต้องขอบคุณแทนชาวเมืองก่อนที่ช่วยกำจัดเทพทะเลและกบฏอาหารทะเล เมืองพลอโอเชียนจะไม่ลืมบุญคุณ #speaker:เจ้าเมือง #portrait:LordP

เอาหละ กลับเข้าเรื่อง ในทวีปนี้มีคนที่เรียกตัวเองว่านักโบราณคดีกำลังเดินทางไปทั่วทั้งทวีปเพื่อรวบรวมหลักฐานทางประวัติศาสตร์และค้นหาความจริงเกี่ยวกับต้นกำเนิดของโลกใบนี้#speaker:เจ้าเมือง #portrait:LordP

บางทีถ้าเป็นเขา เขาอาจจะช่วยเจ้าได้ก็ได้#speaker:เจ้าเมือง #portrait:LordP

ขอบคุณสำหรับข้อมูลครับ แต่ตอนนี้เขาอยู่ที่ไหนหละท่าน!? #speaker:Player #portrait:Player

เอ่อ.. จากที่ได้ยินมาล่าสุดเขาอยู่เมือง คาเวกตาร์ หนะ #speaker:เจ้าเมือง #portrait:LordP

โอ้ยังไงเทพตัวต่อไปก็อยู่ที่เมืองนั้นอยู่ดี เป็นจุดหมายต่อไปของเราพอดี#speaker:Player #portrait:Player 

เอาหละก่อนออกเดินทางให้กลับมาหาข้าอีกครั้ง บางทีข้าอาจจะคิดอะไรบางอย่างออก#speaker:เจ้าเมือง #portrait:LordP

ได้ครับ#speaker:Player #portrait:Player
->DONE

=== start406 ===
ผมพร้อมที่จะไปเมืองคาเวกตาร์แล้วครับ#speaker:Player #portrait:Player

เดี๋ยวก่อนเจ้าหนู ก่อนจะไปที่นั่นเจ้ามีอีกที่ที่ต้องไป

เอ่อ.. แมกมาทอสหรอครับ?#speaker:Player #portrait:Player

ไม่ใช่ ๆ เจ้าเมืองคาเวกตาร์เป็นลูกชายของเจ้าเมืองเซนเทรียนา งั้นก็ไปหาเจ้าเมืองเซนเทรียนาก่อนสิ ยังไงก็เป็นทางผ่านใช่ไหมหละ?#speaker:เจ้าเมือง #portrait:LordP

+ [ยอมรับ]
    เอ่อ.. ยังงั้นก็ได้ครับ งั้นไปก่อนนะครับ#speaker:Player #portrait:Player

    ->ForthExamIntro
+ [ปฏิเสธ]
    คิดๆดูแล้วยังต้องเตรียมตัวมากกว่านี้ เดี๋ยวกลับมาหาครับ#speaker:Player #portrait:Player
    ->DONE
    
=== ForthExamIntro ===
รออยู่นะตัวเธอ เมื่อไหร่เธอจะโผล่มา#speaker:Player #portrait:Player

ข้ารู้ว่าเจ้าคิดถึง แต่ไม่ต้องเรียกหาก็ได้ ยังไงข้าก็ต้องมา#speaker:อาซิลรา #portrait:Azilra

เอาหละคุณผู้สร้าง พอจะตอบมาได้รึยังทำไมถึงตีกันเอง แล้วมนุษย์หายไปไหนหมด?#speaker:Player #portrait:Player

ไม่ไปหาเจ้านักโบราณคดีนั่นก่อนเรอะ? บางทีเจ้าอาจจะได้คำตอบจากเขาก็ได้นะ?#speaker:อาซิลรา #portrait:Azilra

สปอยหน่อยดิ#speaker:Player #portrait:Player

ไม่หละ อย่าลืมว่าเจ้ากำลังเผชิญกับบททดสอบสวรรค์ เตรียมใจไว้ซะ!#speaker:อาซิลรา #portrait:Azilra
->question1

=== question1 ===
~ProboceanScore=0
1/10: ในการทอดลูกเต๋า 1 ลูก 1 ครั้ง จงหาความน่าจะเป็นของเหตุการณ์ที่ลูกเต๋าขึ้นแต้ม 3
+ [1/2]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2
+ [1/4]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2
+ [1/6]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ProboceanScore = ProboceanScore + 1
    ->question2
+ [1/8]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2

=== question2 ===
2/10: ในการทอดลูกเต๋า 1 ลูก 1 ครั้ง จงหาความน่าจะเป็นของเหตุการณ์ที่ลูกเต๋าขึ้นแต้มไม่ตํ่ากว่า 4
+ [1/2]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ProboceanScore = ProboceanScore + 1
    ->question3
+ [1/4]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3
+ [1/6]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3
+ [1/8]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3

=== question3 ===
3/10: เมื่อหยิบไพ่ 1 จากสํารับ ซึ่งมีไพ่อยู่ 52 ใบ จงหาความน่าจะเป็นที่ไพ่ใบนั้นจะเป็นโพแดง
+ [1/2]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4
+ [1/4]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ProboceanScore = ProboceanScore + 1
    ->question4
+ [1/6]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4
+ [1/8]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4

=== question4 ===
4/10: กล่องใบหนึ่งมีหลอดไฟดี 7 ดวง และหลอดไฟเสีย 3 ดวง ปนกัน สุ่มหยิบหลอดไฟมา 5 ดวง จงหาความน่าจะเป็นที่ได้หลอดไฟดีทั้งหมด
+ [5/10]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5
+ [7/21]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5
+ [21/35]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5
+ [21/252]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ProboceanScore = ProboceanScore + 1
    ->question5

=== question5 ===
5/10: โยนเหรียญบาท 3 เหรียญ 1 ครั้ง มีความเป็นไปได้กี่แบบ
+ [2]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question6
+ [4]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question6
+ [8]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ProboceanScore = ProboceanScore + 1
    ->question6
+ [16]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question6

=== question6 ===
6/10: ทอดลูกเต๋า 2 ลูก 1 ครั้ง ความน่าจะเป็นที่ลูกเต๋าจะออกแต้มรวมกันเท่ากับ 8 เป็นเท่าใด
+ [3/36]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question7
+ [4/36]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question7
+ [5/36]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ProboceanScore = ProboceanScore + 1
    ->question7
+ [6/36]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question7

=== question7 === 
7/10: หยิบไพ่ 1 ใบจากสำรับ จงหาความน่าจะเป็นที่จะได้ไพ่สีแดงที่เป็นรูปหน้าคน
+ [2/52]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question8
+ [4/52]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question8
+ [6/52]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ProboceanScore = ProboceanScore + 1
    ->question8
+ [8/52]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question8

=== question8 ===
8/10: สุ่มตัวอักษร 1 ตัว จากคำว่า "somethings" ความน่าจะเป็นที่จะได้ตัวอักษรที่เป็นสระเป็นเท่าใด
+ [0.3]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ProboceanScore = ProboceanScore + 1
    ->question9
+ [0.5]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question9
+ [0.7]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question9
+ [0.9]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question9

=== question9 ===
9/10: จำนวนนับตั้งแต่ 1 - 20 ความน่าจะเป็นที่จะมี 3 หารลงตัวตรงกับข้อใด
+ [0.25]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question10
+ [0.30]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ProboceanScore = ProboceanScore + 1
    ->question10
+ [0.35]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question10
+ [0.40]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question10

=== question10 ===
10/10: ในกล่องใบหนึ่งมีเบี้ย 6 อัน ซึ่งแต่ละอันเขียนตัวเลข 3,4,7,9,10  หรือ 11 ไว้ถ้าสุ่มหยิบเบี้ย 1 อัน ออกมาจากกล่องใบนี้ จงหาโอกาสที่จะได้เบี้ยที่มีตัวเลขที่เป็นจำนวนคู่
+ [1/8]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate
+ [1/5]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate
+ [1/3]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ProboceanScore = ProboceanScore + 1
    ->Evaluate
+ [1/2]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate

=== Evaluate ===
เจ้าได้ {ProboceanScore}/10 คะแนน #speaker:อาซิลรา #portrait:Azilra
{
- ProboceanScore < 8: ->BadGrade
- ProboceanScore >= 8: ->GoodGrade
}
->DONE


//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra

=== BadGrade ===
เจ้าทำได้แค่นี้งั้นเรอะ!? อย่าหวังเลยว่าจะออกไปจากช่วงเวลานี้ได้ จงติดอยู่ในวังวนอันไร้สิ้นสุดนี้เถอะ เจ้ามนุษย์ #speaker:อาซิลรา #portrait:Azilra
->DONE

=== GoodGrade ===
~questAccepted = true
~isS406 = true
เก่งมาก เจ้ามนุษย์ เจ้าสามารถผ่านบททดสอบนี้ได้ แต่ที่เหลือหละ? ข้าหวังว่าเจอกันครั้งหน้า เจ้ายังคงเก่งให้ได้แบบนี้อยู่นะ วะฮะฮะฮ่า! #speaker:อาซิลรา #portrait:Azilra

พูดมากจริงเห้ย! เดี๋ยวเหอะ เดี๋ยวชั้นจะไปกระชากหน้ากากของนายก็มาเอง! #speaker:Player #portrait:Player
->DONE