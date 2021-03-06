INCLUDE globals.ink

{isSS209 == false: ->notTestYet}
{isSS209 == true && isD209 == false: ->finish209 }
{isS301 == false && isD209 == true: ->start301}
{isC301 == true && isD301 == false:->finish301}
{isD301 == true && isS302 == false:->start302}
{isD302 == true && isS303 == false:->start303}
{isCC303 == true && isD303 == false:->finish303}
{isD305 == true && isS306 == false :->start306}
{isC306 == true && isD306 == false: ->finish306}
{isD306 == true: ->AllDone}
->AllDone

//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:เจ้าเมือง #portrait:LordF

=== notTestYet ===
.

(กลับไปคุยกับยาม1เพื่อทำความเข้าใจกฏของเมืองก่อน)
->DONE

=== AllDone ===
.

ขอบคุณสำหรับความพยายามของท่านมากเพื่อช่วยเมืองและโลกของเรา#speaker:เจ้าเมือง #portrait:LordF
->DONE

=== finish209 ===
~questTurnin = true
~isD209 = true
นานมาแล้วที่เราไม่ได้เห็นเผ่ามนุษย์ ยินดีต้อนรับผู้หลงเหลือของเผ่ามนุษย์สู่ฟอเรติน่า#speaker:เจ้าเมือง #portrait:LordF

ยินดีที่ได้พบครับ ท่านเจ้าเมืองฟอเรติน่า#speaker:Player #portrait:Player

ยินดีที่ได้พบแล้วก็เจ้าเมืองสโลปาเคียร์ฝากความคิดถึงมากถึงท่านด้วย#speaker:อาซิลรา #portrait:Azilra

อ๊า!? เจ้านั่นกล้าพูดเรื่องนี้ต่อหน้าคนแปลกหน้าได้ยังไงกัน!?#speaker:เจ้าเมือง #portrait:LordF

ชั้นได้กลิ่นตุๆ ชู้รักชัดๆ#speaker:อาซิลรา #portrait:Azilra

เอ่อท่านเจ้าเมืองครับ เจ้าเมืองสโลปาเคียร์ให้พวกผมมาช่วยต่อกรกับเทพที่กำลังโจมตีเมืองครับ#speaker:Player #portrait:Player

เอ๋? แต่เทพแห่งป่าบอกกับเราเองหนิว่าเขาจะไม่โจมตีเมืองแล้วจะมาอาศัยอยู่รอบๆเมือง#speaker:เจ้าเมือง #portrait:LordF

เทพพวกนี้คือสิ่งมีชีวิตที่ได้รับพลังมาจากตัวตนปริศนาที่อยู่เบื้องหลังครับ พวกเขาจะโจมตีทุกเมืองตามคำสั่ง ดังนั้นการเห็นเทพแห่งป่าไม่ทำตามคำสั่งนี้ผมเกรงว่าไม่เขามีแผนอื่น เขาก็ต้องโดนสั่งให้มาโจมตีเมืองในเร็ววันอยู่ดี#speaker:Player #portrait:Player

ถ้าเป็นแบบนั้นจริงๆ นั่นจะเป็นปัญหาอย่างมาก พวกเธอบอกว่ามาเพื่อช่วยเราใช่หรือไม่?#speaker:เจ้าเมือง #portrait:LordF

ใช่ครับ พวกผมมาเพื่อถามหาข้อมูลเกี่ยวกับเผ่ามนุษย์และช่วยเหลือเมืองนี้ครับ#speaker:Player #portrait:Player

เอาหละ เราจะบอกข้อมูลของเผ่ามนุษย์ที่เรารู้ให้หลังจากที่เธอช่วยเราแก้ปัญหาเทพแห่งป่าได้ เรารู้สึกว่าตั้งแต่เทพแห่งป่าเข้ามาก็ยิ่งมีปีศาจต้นไม้เกิดขึ้นมามากขึ้น#speaker:เจ้าเมือง #portrait:LordF

โดยปกติของเผ่าไม้ เมื่อพวกเราแก่ตัวลง พวกเราก็จะยิ่งกลายสภาพกลายเป็นต้นไม้มากยิ่งขึ้นจนกระทั่งสิ้นอายุไขในฐานะสิ่งมีชีวิตที่มีสติปัญญา พวกเราจะกลายเป็นต้นไม้อย่างสมบูรณ์ #speaker:เจ้าเมือง #portrait:LordF

แต่ว่าสิ่งผิดปกติก็เกิดขึ้นเมื่ออยู่ๆวันหนึ่ง ต้นไม้ที่ไม่สมควรจะมีสติปัญญาพวกนั้นกลับมีสติปัญญาขึ้นมาแล้วก็เริ่มจับกลุ่มกันและเข้าทำร้ายพวกเราเผ่าไม้ #speaker:เจ้าเมือง #portrait:LordF

ถ้าข้อสันนิษฐานของเราเป็นจริงละก็ เทพแห่งป่าคงจะมีพลังในการเพิ่มจำนวนและสั่งการปีศาจต้นไม้อย่างแน่นอน#speaker:เจ้าเมือง #portrait:LordF

งั้นพวกเราจะเพิ่มจากกำจัดปีศาจต้นไม้ที่มากขึ้นก่อนสินะครับ#speaker:Player #portrait:Player

ใช่แล้วหละ เราอยากให้พวกเธอไปจัดการกับปีศาจต้นไม้ที่อยู่รอบๆก่อนแล้วก็หวังว่าจะได้ข้อมูลอะไรมากขึ้นระหว่างนั้น#speaker:เจ้าเมือง #portrait:LordF

แต่เราก็อยากให้เธอไปเตรียมตัวมาให้พร้อมก่อน เมื่อเธอพร้อมแล้วก็กลับมาคุยเรื่องนี้กันอีกครั้ง#speaker:เจ้าเมือง #portrait:LordF

ได้ครับ#speaker:Player #portrait:Player
->DONE

=== start301 ===
เธอกลับมาแล้ว เอาหละเราอยากให้เธอไปจัดการปีศาจต้นไม้รอบๆเมือง 5 ตัว เธอพร้อมไหม?#speaker:เจ้าเมือง #portrait:LordF

+ [ยอมรับ]
    พร้อมเสมอครับ #speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS301 = true
    ->DONE
+ [ปฏิเสธ]
    เอ่อ.. ยังไม่พร้อมครับ ขอตัวซักครู่#speaker:Player #portrait:Player
    ->DONE
    
=== finish301 ===
~questAccepted = true
~isD301 = true
ขอบคุณมากๆสำหรับความช่วยเหลือของพวกเธอ โปรดกลับมาอีกครั้งหลังจากพักผ่อนได้หรือไม่ เราพบอะไรแปลกๆเกิดขึ้นในเมืองของเรา#speaker:เจ้าเมือง #portrait:LordF

ได้ครับ ถ้าเป็นเรื่องเร่งด่วนละก็ผมจะกลับมาให้เร็วที่สุด#speaker:Player #portrait:Player
->DONE

=== start302 ===
ท่านเจ้าเมืองครับพวกเรารู้สึกว่า ปีศาจต้นไม้มันมีเยอะจริงๆ ถึงพวกเราจะไม่รู้ว่าก่อนหน้านี้เยอะขนาดไหน แต่ตอนนี้มันเยอะเกินไปมากๆ#speaker:Player #portrait:Player

เราต้องขอบใจพวกเธอมากสำหรับข่าวสารนี้ จากที่เคยบอกไป ตอนนี้มีเราเรื่องใหม่ที่ร้ายแรงกว่าเกิดขึ้นในเมืองของเราแล้ว#speaker:เจ้าเมือง #portrait:LordF

เรื่องใหม่ที่ร้ายแรงกว่า!?#speaker:Player #portrait:Player

เราได้ข่าวมาว่ามีชาวเมืองผู้หนึ่งมีอาการของโรคประหลาดที่ไม่มีใครรู้จัก ซึ่งชาวเมืองที่ติดเชื้อผู้นี้เป็นเผ่าไม้ที่ได้รับบาดแผลจากปีศาจต้นไม้ โปรดจงไปพบกับย่าสมุนไพรเพื่อสอบถามรายละเอียดของโรคนี้จากนาง#speaker:เจ้าเมือง #portrait:LordF

+ [ยอมรับ]
    ผมจะรีบสะสางเรื่องนี้ให้เร็วที่สุดครับ#speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS302 = true
    ->DONE
+ [ปฏิเสธ]
    ถ้าเป็นเรื่องร้ายแรง งั้นผมขอไปเตรียมตัวก่อนนะครับ#speaker:Player #portrait:Player
    ->DONE

//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
่//#speaker:เจ้าเมือง #portrait:LordF

=== start303 ===
พวกเธอกลับมาแล้ว เป็นอย่างที่เราคิดเลยว่าพวกเธอสามารถช่วยเรารักษาโรคประหลาดที่เกิดขึ้นกับชาวเมืองได้#speaker:เจ้าเมือง #portrait:LordF

ท่านเจ้าเมือง พวกเราคิดว่าโรคประหลาดนี้ต้องเกี่ยวข้องกับเทพแห่งป่าอย่างแน่นอน#speaker:อาซิลรา #portrait:Azilra

ผมก็คิดเหมือนกันครับ ท่านเจ้าเมือง ยังไงเป้าหมายของอีกฝั่งก็คือทำลายเมืองนี้อยู่ดี ถ้าหากอีกฝั่งไม่โจมตีเมืองโดยตรง การให้ลูกน้องบุกโจมตีและแพร่โรคระบาดก็เป็นอีกวิธีที่ทำได้โดยไม่จำเป็นต้องเสียแรงอะไรเลย#speaker:Player #portrait:Player

เอาหละ ถ้าพวกเธอยืนกรานอย่างนั้นหละก็จงไปพบกับเทพแห่งป่าที่อยู่ทางทิศเหนือของเมืองเพื่อยืนยันความจริงเถอะ เราเองก็มีลางสังหรณ์แปลกๆเกี่ยวกับเขาด้วยเหมือนกัน#speaker:เจ้าเมือง #portrait:LordF

+ [ยอมรับ]
    ได้เวลาลุยละ#speaker:Player #portrait:Player
    ~questAccepted = true
    ~isS303 = true
    ->DONE
+ [ปฏิเสธ]
    ตอนนี้ผมยังไม่แน่ใจ เดี๋ยวผมกลับมาครับ#speaker:Player #portrait:Player
    ->DONE

=== finish303 ===
แย่แล้ว! มีคนที่ติดโรคระบาดมากขึ้น ถึงแม้เราจะกักตัวพวกเขาบางส่วนแล้ว แต่ก็ยังระบาดได้อยู่ดี#speaker:เจ้าเมือง #portrait:LordF

ใบไม้ของต้นไม้โลกไม่สามารถรักษาได้หรอครับ?#speaker:Player #portrait:Player

ย่าสมุนไพรบอกว่าพลังมันอ่อนเกินไปได้ จึงทำได้แค่ยับยั้งไม่ให้อาการรุนแรงถึงชีวิต #speaker:เจ้าเมือง #portrait:LordF

ท่านเจ้าเมืองครับ ข้อสันนิษฐานของเราถูกต้อง เทพแห่งป่าอยู่เบื้องหลังของเรื่องทั้งหมดทั้งโรคระบาดและต้นไม้ปีศาจ อีกทั้งผมไม่สามารถจัดการอีกฝ่ายได้ด้วยครับ#speaker:Player #portrait:Player

เจ้านั่นเหมือนจะฟื้นฟูตัวเองได้อยู่ตลอด#speaker:อาซิลรา #portrait:Azilra

ลำบากแล้วสิ เราเองก็ไม่รู้จะทำอะไรดี ได้โปรดไปหาท่านย่าสมุนไพรเพื่อขอความคิดเห็นท่านอีกครั้งเถิด#speaker:เจ้าเมือง #portrait:LordF

~isD303 = true
~questTurnin = true
->DONE

=== start306 ===
เอาหละ ในเมื่อทุกอย่างพร้อมแล้ว แม้จะดูไร้ความรับผิดชอบซักหน่อย แต่ก็ขอฝากอนาคตของเมืองฟอเรติน่าไว้กับเจ้าแล้ว มนุษย์ผู้หลงเหลือ#speaker:เจ้าเมือง #portrait:LordF

ครั้งนี้ยังไงก็ต้องชนะให้ได้ครับ อีกฝั่งมีแค่พลังฟื้นฟูเท่านั้น ในตอนนี้เรารู้วิธียับยั้งมันแล้ว #speaker:Player #portrait:Player

เอาหละ งั้นจะขอทำให้เป็นทางการขึ้นมาหน่อย เราเจ้าเมืองฟอเรติน่าขอให้ท่านนักรบจากเผ่ามนุษย์กำจัดภัยร้ายจากเมืองฟอเรติน่าด้วย#speaker:เจ้าเมือง #portrait:LordF

+ [ยอมรับ]
    ครั้งนี้จะโค่นเจ้านั่นลงได้แน่นอน#speaker:Player #portrait:Player
    ~questAccepted = true
    ~isS306 = true
    ->DONE
+ [ปฏิเสธ]
    ขอไปเตรียมตัวเพื่มก่อนนะครับ ครั้งที่แล้วโดนถมถุยมาเยอะ#speaker:Player #portrait:Player
    ->DONE

=== finish306 ===

ต้องขอบคุณจริงๆ เราไม่รู้ว่าจะตอบแทนเจ้ายังไงดี หากมีอะไรที่พอจะช่วยได้ ได้โปรดกล่าวออกมาเถิด#speaker:เจ้าเมือง #portrait:LordF

ตามที่ได้บอกไว้ก่อนหน้าครับ ผมอยากจะรู้แค่เรื่องราวของเผ่ามนุษย์#speaker:Player #portrait:Player

อ่า นั่นสินะ ในอดีตมีเผ่าพันธุ์ปริศนาอยู่เผ่าพันธุ์นึงซึ่งเราเรียกพวกเขาว่าผู้สร้าง เหล่าผู้สร้างนั้นได้ทำการสร้างทุกอย่างบนโลกใบนี้ ทั้งสรรพชีวิต และผืนดิน อีกทั้งยังคอยอุ้มชูและดูแลเผ่าพันธุ์ต่างๆที่อยู่บนโลกใบนี้ด้วย #speaker:เจ้าเมือง #portrait:LordF

งั้นเหล่าผู้สร้างเกี่ยวข้องกับมนุษย์ด้วยหรอครับ?#speaker:Player #portrait:Player

ถูกแล้ว ถ้าจะกล่าวให้ถูก พวกเขาโปรดปรานเหล่ามนุษย์มากที่สุด แต่ทว่าเรากลับได้ยินมาว่าภัยพิบัติที่เกิดขึ้นกับโลกเมื่อนานมาแล้วนั้นกลับเป็นการทะเลาะกับเองของเหล่าผู้สร้างและส่วนหนึ่งของเผ่ามนุษย์ #speaker:เจ้าเมือง #portrait:LordF

ท้ายที่สุดก็เป็นเหมือนปัจจุบัน ไม่สามารถพบได้ทั้งเผ่ามนุษย์และผู้สร้างเลย ไม่ใช่สิ ตอนนี้เราพบเผ่ามนุษย์แล้วนี่นา#speaker:เจ้าเมือง #portrait:LordF

ไม่รู้ว่ามนุษย์ที่เคยอยู่ที่นี่เป็นเผ่ามนุษย์ที่เกิดที่นี่หรือมนุษย์ที่ข้ามมิติมาเหมือนผมกันแน่ แต่ก็เริ่มมีลางสังหรณ์ว่าผู้ที่อยู่เบื้องหลังพวกเทพนี่อาจจะเป็นผู้สร้างก็ได้#speaker:Player #portrait:Player

อีกไม่นานเดี๋ยวเราก็จะรู้ความจริงเองแหละ เรากำลังจะไปเมืองพลอโบเชียนต่อเลยมั้ย?#speaker:อาซิลรา #portrait:Azilra

อ๊า เมืองพลอโบเชียน เราจำได้ว่าเจ้าเมืองพลอโบเชียนเป็นแกนนำในการอพยพผู้คนมายังทวีปมาเคียร์น่านี้ บางทีเขาอาจจะรู้อะไรบางอย่างก็ได้#speaker:เจ้าเมือง #portrait:LordF

ดีหละ งั้นได้เวลาออกเดินทางอีกครั้งแล้ว ว่าแต่... พลอโบเชียนนี่ไม่ใช่เมืองกลางสมุทรเรอะ?#speaker:Player #portrait:Player

ไม่ต้องกังวล เราสามารถมอบพลังเดินบนผืนน้ำให้กับผู้มีพระคุณของเราได้#speaker:เจ้าเมือง #portrait:LordF

ขอบคุณมากๆนะครับ ทีนี้เราก็เดินบนน้ำได้เหมือนนินจาแล้วสินะ!#speaker:Player #portrait:Player

นินจา? อะไรนั่นหนะ?#speaker:อาซิลรา #portrait:Azilra

เอ่อ... ช่างมันเถอะ แต่เดี๋ยวนะ วิกฤตของเมืองนี้จบแล้ว ได้เวลาที่คนน่ารำคาญจะโผล่หัวออกมาได้แล้วมั้ง?#speaker:Player #portrait:Player


->ThirdExamIntro

=== ThirdExamIntro ===
(เวลาหยุด) พูดไม่ทันขาดคำ#speaker:Player #portrait:Player

ข้ารู้ว่าเจ้าคิดถึงข้า เด็กน้อย วะฮะๆฮ่า! บททดสอบสวรรค์ครั้งที่ 3 มาแล้ว#speaker:อาซิลรา #portrait:Azilra

นายคงเป็นเผ่าพันธุ์ที่คนในโลกนี้เรียกว่าผู้สร้างสินะ#speaker:Player #portrait:Player

อะไรที่ทำให้เจ้าคิดอย่างนั้นหละ?#speaker:อาซิลรา #portrait:Azilra

จากข้อมูลที่ชั้นมีตอนนี้ คิดได้อย่างเดียวว่าคนที่ให้พลังกับเทพพวกนั้นคงจะมีแค่ผู้สร้างเท่านั้นแหละ#speaker:Player #portrait:Player

น่าทึ่งซะจริงเชียว มันทำให้ข้าไม่อยากเสียเวลาให้นานกว่านี้ รับไปซะบททดสอบแห่งสวรรค์!#speaker:อาซิลรา #portrait:Azilra
->question1

=== question1 ===
1/5: จำนวนวิธีทั้งหมดที่จะเลือกของแถม 3 ชิ้นจากของแถมที่มีอยู่ 8 ชิ้นเท่ากับเท่าใด?
~ForetinaScore=0
+ [45]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2
+ [54]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2
+ [65]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2
+ [56]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ForetinaScore = ForetinaScore + 1
    ->question2

=== question2 ===
2/5: ไพ่สำรับหนึ่งมี 4 ชุดคือ โพดำ โพแดง ดอกจิก ข้าวหลามตัด โดยแต่ละชุดมี 13 ใบตั้งแค่ 2-10, A,K,Q และ J จะมีกี่วิธีที่จะหยิบได้ไพ่ 4 ใบที่เป็นชุดเดียวกัน
+ [2860]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ForetinaScore = ForetinaScore + 1
    ->question3
+ [1430]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3
+ [720]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3
+ [640]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3

=== question3 ===
3/5: มีแผ่นเกมในกล่องอยู่ 10 แผ่น เป็นเกมของค่าย Ea จำนวน 3 แผ่น เกมของค่าย FS จำนวน 3 แผ่น และเกมของค่าย BT จำนวน 4 แผ่น ถ้าหยิบแผ่นเกมจากกล่องนี้จำนวน 3 แผ่น จงหาจำนวนวิธีที่จะหยิบได้แผ่นเกมของค่าย Ea 2 แผ่น

+ [3]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4
+ [12]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4
+ [21]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ForetinaScore = ForetinaScore + 1    
    ->question4
+ [60]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4

=== question4 ===
4/5: มีนาฬิกาสีดำ 3 เรือน สีแดง 4 เรือน และสีขาว 5 เรือน เลือกนาฬิกาสีละ 2 เรือน จะมีวิธีเลือกทั้งหมดกี่วิธี

+ [90]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5
+ [180]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ForetinaScore = ForetinaScore + 1
    ->question5
+ [270]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5
+ [360]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5

=== question5 ===
5/5: คู่แต่งงาน 4 คู่ได้ที่นั่ง 8 ที่นั่งเรียงติดกันเป็นแนวตรงเพื่อฟังโอเปรา จะมีกี่วิธีที่ให้คู่แต่งงานแต่ละคู่นั่งติดกัน
+ [484]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate
+ [834]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate
+ [438]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate
+ [384]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~ForetinaScore = ForetinaScore + 1
    ->Evaluate

=== Evaluate ===
เจ้าได้ {ForetinaScore}/5 คะแนน #speaker:อาซิลรา #portrait:Azilra
{
- ForetinaScore < 3: ->BadGrade
- ForetinaScore >= 3: ->GoodGrade
}
->DONE


//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra

=== BadGrade ===
เจ้าทำได้แค่นี้งั้นเรอะ!? อย่าหวังเลยว่าจะออกไปจากช่วงเวลานี้ได้ จงติดอยู่ในวังวนอันไร้สิ้นสุดนี้เถอะ เจ้ามนุษย์ #speaker:อาซิลรา #portrait:Azilra
->DONE

=== GoodGrade ===
~questTurnin = true
~isD306 = true
เก่งมาก เจ้ามนุษย์ เจ้าสามารถผ่านบททดสอบนี้ได้ แต่ที่เหลือหละ? ข้าหวังว่าเจอกันครั้งหน้า เจ้ายังคงเก่งให้ได้แบบนี้อยู่นะ วะฮะฮะฮ่า! #speaker:อาซิลรา #portrait:Azilra

พูดมากจริงเห้ย! เดี๋ยวเหอะ เดี๋ยวชั้นจะไปกระชากหน้ากากของนายก็มาเอง! #speaker:Player #portrait:Player
->DONE