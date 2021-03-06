INCLUDE globals.ink
->general
//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:ย่าสมุนไพร #portrait:FMerchant

=== general ===
อิรัชชัยมาเซะ~~ #speaker:ย่าสมุนไพร #portrait:FMerchant
~questAccepted = false
~Cshop = false
~Ccraft = false
+ [ทำภารกิจ]
    {isD301 == true && isS302 == false: ->GoTest302}
    {isCC302 == true && isD302 == false:->finish302}
    {isD303 == true && isS304 == false: ->start304}
    ยังไม่มีอะไรให้ทำหรอก พักผ่อนเถอะเจ้าหนู#speaker:ย่าสมุนไพร #portrait:FMerchant
    ->DONE
+ [เข้าสู่ร้านค้า]
    ~Cshop = true
    [เข้าสู่ร้านขายของ]
    ->DONE
+ [เดินผ่าน]
    ไม่มีอะไรครับ ไว้มีเดี๋ยวจะแวะมาใหม่นะครับ #speaker:Player #portrait:Player
    ->DONE

=== GoTest302 ===
เจ้าคงเป็นเด็กหนุ่มเผ่ามนุษย์ที่นางบอกมาสินะ เราได้รับรู้เรื่องของเจ้าจากเจ้าเมืองแล้วหละ แต่เพื่อความปลอดภัย ข้าคงต้องขอทดสอบเจ้าก่อน หวังว่าเจ้าคงเข้าใจ#speaker:ย่าสมุนไพร #portrait:FMerchant

ไม่มีปัญหาครับ#speaker:Player #portrait:Player

เอาหละ ถ้าเราต้องการตัดสินเด็กฝึกงานทั้งหมด 5 คน เราต้องการเด็กฝึกงานชาย 2 คนจากผู้สมัครชาย 5 และเด็กฝึกงานหญิง 3 คนจากผู้สมัครหญิง 7 คน เราจะเลือกได้ทั้งหมดกี่วิธี#speaker:ย่าสมุนไพร #portrait:FMerchant

+ [150]
    #speaker:ย่าสมุนไพร #portrait:FMerchant
    ->DONE
+ [300]
    ->DONE
+ [320]
    ->DONE
+ [350]
    ->2ndQuestion

=== 2ndQuestion ===
แล้วถ้าเกิดว่าตาแก่คนนึงมีหนังสือ 7 เล่ม ในขณะที่ตาแก่อีกคนนึงมีหนังสือ 9 เล่ม ตาแก่ทั้งสองคนนี้จะมีวิธีในการแลกหนังสือกันคนละ 2 เล่มได้กี่วิธี#speaker:ย่าสมุนไพร #portrait:FMerchant

+ [777]
    ->DONE
+ [756]
    ->continue302
+ [675]
    ->DONE
+ [765]
    ->DONE

=== continue302 ===
ทีนี้ก็ไม่มีปัญหาแล้วหละ #speaker:ย่าสมุนไพร #portrait:FMerchant

พวกเราได้ยินมาจากเจ้าเมืองว่ามีโรคประหลาดเกิดขึ้น ถ้าเป็นไปได้ช่วยเล่ารายละเอียดหน่อยได้ไหมครับ?#speaker:Player #portrait:Player

ได้สิ อย่างที่พวกเธอน่าจะรู้ๆกันว่าช่วงนี้มีการเกิดขึ้นของต้นไม้ปีศาจจำนวนมาก มีชาวเมืองคนนึงที่ออกไปเก็บสมุนไพรอยู่นอกเมืองบังอาจโดนโจมตีจากต้นไม้ปีศาจเข้าแต่ก็หนีมาได้ #speaker:ย่าสมุนไพร #portrait:FMerchant

แต่ในระหว่างรักษาตัวก็ดันมีอาการประหลาดเกิดขึ้น ซึ่งอาการประหลาดนี้จะทำให้เผ่าไม้โดนสูบพลังชีวิตไปแล้วกลายเป็นต้นไม้รวดเร็วยิ่งขึ้น #speaker:ย่าสมุนไพร #portrait:FMerchant

จากนั้นชาวเมืองที่มาดูอาการก็เริ่มมีอาการแบบเดียวกัน ซึ่งเรามั่นใจได้ว่ามันเป็นโรคติดต่ออย่างแน่นอน#speaker:ย่าสมุนไพร #portrait:FMerchant

นี่มันโรคร้ายแรงสำหรับเผ่าไม้มากเลยนี่นา เรื่องนี้มีอะไรเกี่ยวข้องกับเทพแห่งป่ารึเปล่านะ..#speaker:Player #portrait:Player

ในตอนนี้เรายังฟันธงอะไรไม่ได้หรอก แต่เราอยากให้เจ้าไปหาสมุนไพรเพื่อยับยั้งอาการในระหว่างนั้นเราจะได้หาทางรักษาคนไข้#speaker:ย่าสมุนไพร #portrait:FMerchant

ได้ครับ ได้โปรดบอกมาเลยว่าท่านต้องการอะไร#speaker:Player #portrait:Player

จงไปจัดการต้นไม้ปีศาจแล้วนำรากไม้ของพวกมันมาซัก 10 ชิ้น แล้วถ้าหากเป็นไปได้หน้าเมืองของเรามีกล่องปริศนาซ่อนอยู่ #speaker:ย่าสมุนไพร #portrait:FMerchant

เราคิดว่าเผ่ามนุษย์อย่างเจ้าน่าจะเปิดมันได้ เรารู้สึกว่าอะไรก็ตามที่อยู่ในกล่องนั้นสามารถที่จะช่วยเราได้#speaker:ย่าสมุนไพร #portrait:FMerchant

ถ้าเจ้าจัดการปีศาจต้นไม้ครบ 10 ตัวแล้วก็ฝากนำของที่อยู่ข้างในกล่องนั้นกลับมาให้เราหน่อยนะ#speaker:ย่าสมุนไพร #portrait:FMerchant

+ [ยอมรับ]
    ได้ครับ พวกเราจะรีบกลับมาให้เร็วที่สุด#speaker:Player #portrait:Player

    ~questAccepted = true
    ~isS302 = true
    ->DONE
+ [ปฏิเสธ]
    ตอนนี้ผมยังไม่แน่ใจ เดี๋ยวผมกลับมาครับ#speaker:Player #portrait:Player
    ->DONE

=== finish302 ===
~questTurnin = true
~isD302 = true
เอ่อ ท่านย่าสมุนไพรครับ เราได้รากแก้วมาก็จริง แต่ข้างในกล่องปริศนาก็มีแต่ใบไม้แห้งใบนี้ครับ#speaker:Player #portrait:Player

นี่มัน... ไม่น่าเชื่อว่าเรายังมีโอกาสได้เห็นมันอยู่ แม้จะเป็นเพียงแค่ใบไม้แห้งๆใบเดียว #speaker:ย่าสมุนไพร #portrait:FMerchant

ดูเหมือนว่าจะคุ้มค่านะ พอจะบอกพวกเราได้รึเปล่าว่าใบไม้นั้นคืออะไรกันแน่?#speaker:อาซิลรา #portrait:Azilra

แน่นอน นี่คือสิ่งหลงเหลือจากตำนานเอาเก่าแก่ เป็นสิ่งที่กำเนิดขึ้นมาพร้อมๆกับโลกใบนี้ นั่นก็คือต้นไม้โลกที่คอยค้ำจุนทุกสรรพชีวิต มีสิ่งมีชีวิตมากมายเกิดขึ้นมาได้เพราะต้นไม้โลก #speaker:ย่าสมุนไพร #portrait:FMerchant

แต่หลังจากภัยพิบัตินั้นครานั้น ทำให้ต้นไม้โลกต้องสูญเสียพลังของมันไปและจากพวกเราไปในที่สุด ใบไม้นี้คือใบไม้จากต้นไม้โลกไม่ผิดแน่#speaker:ย่าสมุนไพร #portrait:FMerchant

แต่แค่ใบไม้จะช่วยอะไรได้หรือครับ? มันดูแห้งเกินกว่าจะมีอะไรเหลือให้เราใช้ได้แล้วนะครับ#speaker:Player #portrait:Player

ไม่เลยๆ แค่ใบไม้แห้งๆนี่ก็เพียงพอแล้ว พลังของต้นไม้โลกสามารถรักษาได้ทุกโรค แม้จะเป็นเพียงแค่ใบไม้ แต่ถ้าหากสามารถรีดพลังมาได้ส่วนหนึ่ง เราสามารถรักษาโรคระบาดนี้ได้อย่างแน่นอน#speaker:ย่าสมุนไพร #portrait:FMerchant

เท่านี้ก็คลี่คลายแล้วสินะ#speaker:Player #portrait:Player

บางทีเราอาจจะต้องไปหาเจ้าเมืองก่อนแล้วขอไปตรวจสอบเทพแห่งป่า ชั้นว่าเรื่องนี้ต้องมีส่วนเกี่ยวข้องกับเทพแห่งป่าแน่ๆ#speaker:อาซิลรา #portrait:Azilra
->DONE

=== start304 ===
อ่า อย่างนี้นี่เอง ทำไมเราถึงไม่คิดออกให้เร็วกว่านี้นะ เป็นไปได้ว่าอีกฝ่ายนั้นมีพลังของต้นไม้โลก ทำให้อีกฝั่งสามารถฟื้นฟูได้ไม่สิ้นสุด อีกทั้งยังสามารถควบคุมพลังชีวิตได้อีกด้วย#speaker:ย่าสมุนไพร #portrait:FMerchant

งั้นเราก็ไม่มีหวังเลยหรอครับ!?#speaker:Player #portrait:Player

แม้จะเกลียดที่ต้องทำแบบนี้ แต่มีเพียงอย่างเดียวเท่านั้นที่เป็นปฏิปักษ์กับพลังของต้นไม้โลก นั่นคือคำสาป หากเจ้าสามารถสร้างอุปกรณ์ที่ฝังพลังคำสาปลงไปได้#speaker:ย่าสมุนไพร #portrait:FMerchant

ตอนนี้เราไม่สามารถออกไปช่วยได้เพราะต้องประคองอาการของผู้ติดเชื้อเอาไว้ โชคดีที่เมืองของเรามีนักเดินทางที่เป็นช่างตีเหล็กแวะมาพักอยู่ #speaker:ย่าสมุนไพร #portrait:FMerchant

โปรดไปขอร้องเขาในนามของเมืองฟอเรติน่าด้วยเถอะ #speaker:ย่าสมุนไพร #portrait:FMerchant
+ [ยอมรับ]
    ได้ครับ อย่าหักโหมมากเกินไปนะครับ ผมเกรงว่าท่านย่าจะติดโรคเหมือนกัน#speaker:Player #portrait:Player
    ->DONE
+ [ปฏิเสธ]    
    ตอนนี้ผมยังไม่แน่ใจ เดี๋ยวผมกลับมาครับ#speaker:Player #portrait:Player
    ->DONE