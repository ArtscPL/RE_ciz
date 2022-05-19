INCLUDE globals.ink
//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:เจ้าเมือง #portrait:LordS
//->SecondExamIntro
{isD204 == true && isS205 == false:->start205}
{isSS205 == true && isSSS205 == false: ->205part2}
{isD206 == true && isS207 == false: ->start207}
{isC207 == true && isD207 == false: ->finish207}
{isD207 == true && isS208 == false: ->start208}
{isC208 == true && isD208 == false: ->finish208 }
{isD208 == true && isS209 == false: ->start209}
{isSS404 == true && isCC404 == false: ->404get}

=== 404get ===
ท่านเจ้าเมือง ผมมีเรื่องจะขอ#speaker:Player #portrait:Player

ว่าไง ข้ายินดีช่วยอยู่แล้ว#speaker:เจ้าเมือง #portrait:LordS

(อธิบายสถานการณ์)#speaker:Player #portrait:Player

เอาหละ ข้าเข้าใจเรื่องราวทั้งหมดแล้ว รับของไป#speaker:เจ้าเมือง #portrait:LordS
~isCC404 = true
->DONE

=== start205 ===
เจ้ามาแล้ว เด็กหนุ่มเผ่ามนุษย์!#speaker:เจ้าเมือง #portrait:LordS

เอ๋? ท่านรู้ได้ยังไงว่าผมเป็นมนุษย์!?#speaker:Player #portrait:Player

มันเป็นความรู้สึกหนะ ข้าต้องขอบใจเจ้า หากไม่มีเจ้าข้าคงต้องทิ้งชีวิตไว้ที่นั่นแล้วเมืองนี้ก็คงต้องล่มสล#speaker:เจ้าเมือง #portrait:LordSายแน่ๆ

มันเป็นสิ่งที่ผมควรทำอยู่แล้วครับ ผมไม่สมควรได้รับคำขอบคุณหรอก ว่าแต่เทพน้ำแข็งแข็งแกร่งขนาดไหนหรอครับ#speaker:Player #portrait:Player

ข้าไม่รู้จะอธิบายเจ้ายังไงดี ข้าไม่สามารถสร้างความเสียหายให้กับมันได้เลย เหมือนว่าเขตน้ำแข็งเป็นเขตที่มันทรงอำนาจมากที่สุด#speaker:เจ้าเมือง #portrait:LordS

ถ้าอย่างงั้นเราไม่มีทางจะชนะอีกฝ่ายได้เลยหรอครับ #speaker:Player #portrait:Player

ยังหรอก มันยังมีวิธีอยู่ ถึงจะแข็งแกร่ง แต่ยังไงก็ต้องมีจุดอ่อน หากโจมตีด้วยพลังแห่งไฟก็น่าจะทะลุการป้องกันของมันได้#speaker:เจ้าเมือง #portrait:LordS

พลังแห่งไฟ... หรือว่า...? ผมจำเป็นต้องใช้อาวุธที่มีพลังแห่งไฟสินะครับ#speaker:Player #portrait:Player

ถูกแล้วหละ เจ้าจำเป็นต้องสร้างอาวุธที่มีพลังแห่งไฟขึ้น แต่เราไม่มีผลึกแห่งไฟที่เป็นส่วนผสมหลักเลย เจ้าสามารถหาผลึกแห่งไฟได้จากเขตแมกมาทอส แต่เจ้าในตอนนี้ยังอ่อนแอเกินไป#speaker:เจ้าเมือง #portrait:LordS

ข้าจำได้ว่าเจ้าเมืองเซนเทรียน่ามีผลึกไฟอเวจีเก็บเอาไว้ ไปเอาผลึกนั่นมาแล้วกลับมาหาข้าอีกครั้ง#speaker:เจ้าเมือง #portrait:LordS
+ [ยอมรับ]
    ไว้ผมจะรีบไปรีบกลับนะครับ#speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS205 = true
    ->DONE
+ [ปฏิเสธ]
    ขอไปเตรียมสัมภาระเพิ่มก่อนนะครับ#speaker:Player #portrait:Player
    ->DONE

=== 205part2 ===
เยี่ยมมาก! ที่คือผลึกไฟอเวจีไม่ผิดแน่ เจ้าจงไปหาช่างตีเหล็กเพื่อสร้างอาวุธซะ#speaker:เจ้าเมือง #portrait:LordS
ชั้นละเกลียดจริงๆที่ต้องไปเจอตาแก่นั่นอีกครั้ง#speaker:อาซิลรา #portrait:Azilra
งั้นก็รีบ ๆ ทำงานนี้ให้เสร็จเถอะ#speaker:Player #portrait:Player
~isSSS205 = true
->DONE

=== start207 ===
เจ้าได้อาวุธธาตุไฟมาแล้ว ได้เวลาคิดบัญชีแล้ว! เอาหละจงไปกำจัดเทพน้ำแข็งซะ ข้าขอฝากอนาคตของเมืองสโลปาเคียร์ไว้ที่เจ้า#speaker:เจ้าเมือง #portrait:LordS

+ [ยอมรับ]
    ผมจะกำจัดเทพน้ำแข็งได้อย่างแน่นอน! ไว้ใจได้เลยครับ#speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS207 = true
    ->DONE
+ [ปฏิเสธ]
    ขอไปเตรียมสัมภาระเพิ่มก่อนนะครับ#speaker:Player #portrait:Player
    ->DONE
->DONE

=== finish207 ===
ข้ารู้อยู่แล้วว่าเจ้าต้องทำได้ ข้าต้องขอขอบคุณเจ้าแทนคนทั้งเมืองสโลปาเคียร์ด้วย #speaker:เจ้าเมือง #portrait:LordS

มันเป็นสิ่งที่พวกเราควรทำอยู่แล้วครับ ท่านอย่าได้ชมกันเลย#speaker:Player #portrait:Player

ฮะฮ่าไม่ได้หรอก คนทำดีย่อมต้องสมควรได้รับการตอบแทน แต่ทว่า..

แต่ทว่า..?#speaker:Player #portrait:Player

ที่จริงแล้วข้ามีคำขออีกอย่างหนะ ไว้เจ้าพักฟื้นเสร็จแล้วช่วยรับฟังหน่อยได้ไหม?

ไม่มีปัญหาครับ ใช้เวลาไม่นานหรอกครับ #speaker:Player #portrait:Player

เอ็งไปเอาแรงมาจากไหนเยอะแยะฟะ แค่บินเฉยๆนี่ก็เหนื่อยละนะ#speaker:อาซิลรา #portrait:Azilra
~isD207 = true
~questTurnin = true
->DONE

//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
่//#speaker:เจ้าเมือง #portrait:LordS

=== start208 ===
โอ้เจ้ากลับมาแล้ว เอาหละเจ้าพร้อมจะฟังคำขอของข้ารึเปล่าหละ?#speaker:เจ้าเมือง #portrait:LordS

+ [ยอมรับ]
    ไม่เคยมีปัญหาอยู่แล้วครับ#speaker:Player #portrait:Player
    
    เยี่ยมมาก... ดูเหมือนว่าแผลจากตอนที่ข้าสู้กับเทพน้ำแข็งจะมีพิษเย็นร้ายแรง ในตอนที่ข้ากลับเมืองมาพักฟื้นข้าคิดว่าอาการของข้าจะดีขึ้นแต่มันกลับแย่ลงอย่างมาก #speaker:เจ้าเมือง #portrait:LordS
    
    เพื่อที่จะรักษาแผลนี้ ข้าจึงอยากให้เจ้าช่วยไปหาต้นหยกเยือกแข็ง 10 ต้นและผงเวทมนตร์ 30 ชุดมาให้ข้าก่อนที่อาการจะแย่ลงไปมากกว่านี้#speaker:เจ้าเมือง #portrait:LordS
    
    ของพวกนี้ ดูรวมๆแล้ว จัดการปีศาจรอบๆเมือง 15 ตัวก็ได้มาครบละ#speaker:อาซิลรา #portrait:Azilra
    
    ไม่ต้องห่วงครับ ผมจะรีบกลับมาให้เร็วที่สุด#speaker:Player #portrait:Player
    ~isS208 = true
    ~questAccepted = true
    ->DONE


=== finish208 ===
~isD208 = true
~questTurnin = true

ข้าติดหนี้บุญคุณเจ้าอีกครั้งเด็กหนุ่มเผ่ามนุษย์ เจ้าคือผู้กอบกู้ของพวกเรา #speaker:เจ้าเมือง #portrait:LordS
->DONE

=== start209 ===

พวกข้าติดค้างพวกเจ้าอยู่มาก หากมีอะไรที่ข้าพอจะช่วยได้ ข้าก็จะช่วยเต็มที่ ขอเพียงแค่เจ้าเอ๋ยปากออกมา #speaker:เจ้าเมือง #portrait:LordS

ผมอยากจะถามเรื่องของเผ่ามนุษย์ครับ  #speaker:Player #portrait:Player

เผ่ามนุษย์งั้นสินะ ข้าไม่ได้มีความทรงจำเกี่ยวกับเผ่าพันธุ์ของเจ้ามากนักหรอก ข้าเคยตั้งสมมติฐานเมื่อนานมาแล้วเกี่ยวกับมนุษย์ ข้าเชื่อว่าพวกเขาไม่ใช่คนของโลกนี้  #speaker:เจ้าเมือง #portrait:LordS

บางทีการจากไปของพวกเขาอาจจะหมายถึงกลับสู่โลกของพวกเขาเหมือนแนวทางที่เจ้ากำลังหาอยู่ก็เป็นได้ สมมติฐานของข้าพอจะช่วยอะไรเจ้าได้บ้างรึเปล่า? #speaker:เจ้าเมือง #portrait:LordS

ช่วยได้มากเลยครับ! ถ้าสมมติฐานนี้เป็นจริงแสดงว่าผมสามารถกลับไปที่โลกที่ผมเคยอยู่ได้ #speaker:Player #portrait:Player

ฮะฮ่า โล่งอกไปที ต่อจากนี้เจ้าจะทำอะไรต่อหละ? บางทีอาจจะไปที่เมืองฟอเรติน่าไม่ก็พลอโบเชียนสินะ #speaker:เจ้าเมือง #portrait:LordS

ให้ข้าแนะนำเจ้าแล้วกัน ฟอเรติน่าและพลอโบเชียนนั้นอยู่ใกล้กันอย่างมาก เจ้าจำเป็นต้องผ่านเมืองฟอเรติน่าก่อนจะไปยังเมืองพลอโบเชียนได้  #speaker:เจ้าเมือง #portrait:LordS

จากสถานการณ์ตอนนี้ข้าเกรงว่าทั้งสองเมืองคงกำลังถูกโจมตีโดยสิ่งมีชีวิตที่เรียกตัวเองว่าเทพอยู่เหมือนกัน ข้าจึงอยากให้เจ้าไปช่วยเจ้าเมืองฟอเรติน่าต่อสู้กับภัยร้ายในครั้งนี้ #speaker:เจ้าเมือง #portrait:LordS
ยังไงซะผมก็ต้องไปหาเบาะแสของเผ่ามนุษย์จากทุกเมืองอยู่แล้ว อีกอย่างผมไม่สามารถทนดูเมืองทั้งเมืองถูกทำลายไปได้หรอกครับ#speaker:Player #portrait:Player

ข้ามั่นใจว่าเจ้าเมืองฟอเรติน่าจะชอบเจ้าอย่างแน่นอน เผ่าไม้เป็นพวกรักสงบ หากเจ้าไปช่วยแบ่งเบาภาระในการต่อสู้ เจ้าจะได้รับการปฏิบัติที่ดีขึ้น แล้วก็สุดท้าย อืม... ฝากบอกนางด้วยหละว่าข้าคิดถึง#speaker:เจ้าเมือง #portrait:LordS

ว้าว เจ้าเมืองแห่งน้ำแข็งหลงรักเทพธิดาแห่งพรไพร ช่างเติมแต่งจินตนาการได้ดีเหลือเกิน~ #speaker:เจ้าเมือง #portrait:LordS

อย่าเสียมารยาทเจ้าลูกไฟ!! ขออภัยนะครับ งั้นไว้เจอกันไหม ลาก่อนครับ!!#speaker:Player #portrait:Player
~isS209 = true
~questAccepted = true
->SecondExamIntro

=== SecondExamIntro ===
ทำไมรู้สึกเหมือนเวลาหยุดลง เดี๋ยวนะเรากำลังออกจากเมืองสโลปาเคียร์ อย่าบอกนะว่า…#speaker:Player #portrait:Player

แท่นแท๋นแท๊น~~~ ยินดีด้วยที่ล้มเทพแห่งน้ำแข็งลงได้ ช่างน่าอิจฉาศักยภาพของเผ่าพันธุ์เจ้าซะจริงๆ #speaker:อาซิลรา #portrait:Azilra

เวรเอ้ย! นี่เราพบกันครั้งที่สองแล้ว อย่างน้อยก็ช่วยบอกชื่อกันหน่อยได้มั้ย!?#speaker:Player #portrait:Player

ไม่#speaker:อาซิลรา #portrait:Azilra

อย่าหยิ่งดิ!!! นายคิดว่าต่อมสงสัยของมนุษย์เป็นยังไงกัน! แต่ในที่สุดชั้นก็ยืนยันได้ซักทีว่านายคือคนที่อยู่เบื้องหลังพวกเทพนั่น#speaker:Player #portrait:Player

ไม่มันสำคัญสำหรับตอนนี้หรอก ณ ตอนนี้สิ่งที่สำคัญที่สุดก็คือบททดสอบแห่งสวรรค์ครั้งที่สองยังไงหละ! ขอให้มีความสุขนะเด็กน้อย วะฮะๆฮ่า!#speaker:อาซิลรา #portrait:Azilra

เสียงหัวเราะของสิ่งมีชีวิตในโลกนี้ช่างมีเอกลักษณ์ซะจริง มาเหอะจะบททดสอบอะไร ไม่เคยหวั่นไหวอยู่แล้ว!#speaker:Player #portrait:Player
->question1

=== question1 ===
1/5: จัดคนครั้งละ 3 คน จากคน 5 คน ให้ยืนเก็บตั๋วที่หน้าประตูหมายเลข 1 หมายเลข 2 และหมายเลข 3 ตามลำดับ จะมีวิธีจัดได้ทั้งหมดกี่วิธี 
~SlopakiaScore = 0
+ [15]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2
+ [30]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2
+ [60]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~SlopakiaScore = SlopakiaScore + 1
    ->question2
+ [80]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question2

=== question2 ===
2/5: จัดบูธแสดงสินค้า 8 บูธแตกต่างกัน เชิงวงกลม จะจัดเป็นแบบต่าง ๆ ได้ทั้งหมดกี่วิธี

+ [720]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3
+ [2040]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3
+ [5040]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~SlopakiaScore = SlopakiaScore + 1
    ->question3
+ [40320]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question3

=== question3 ===
3/5: มีผู้สมัครเล่นเทนนิส 5 คน ถ้าต้องการทีมละ 2 คน โดยแต่ละทีมประกอบด้วยเดี่ยวมือหนึ่งและเดี่ยวมือสอง จะมีวิธีจัดได้ทั้งหมดกี่วิธี 

+ [20]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~SlopakiaScore = SlopakiaScore + 1
    ->question4
+ [15]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4
+ [10]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4
+ [5]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question4

=== question4 ===
4/5: มีกระถางกล้วยไม้อยู่ 9 กระถาง แตกต่างกัน นำมาจัดเรียงสับเปลี่ยนเชิงวงกลมรอบศาลาพัก จะมีวิธีจัดวางทั้งหมดกี่วิธี 

+ [9!]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5
+ [8!]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~SlopakiaScore = SlopakiaScore + 1
    ->question5
+ [7!]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5
+ [7!2!]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->question5

=== question5 ===
5/5: จัดแสดงหนังสือภาษาไทยที่เหมือนกัน 3 เล่ม หนังสือสังคมศึกษาที่เหมือนกัน 4 เล่มและหนังสือภาษาอังกฤษที่เหมือนกัน 2 เล่ม ในตู้แสดงหนังสือในแนวตรง จะเรียงสับเปลี่ยนได้ทั้งหมดกี่วิธี 

+ [360]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate
+ [630]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate
+ [720]
    ยังฝึกมาไม่พอนะ #speaker:อาซิลรา #portrait:Azilra
    ->Evaluate
+ [1260]
    ทำได้ดี #speaker:อาซิลรา #portrait:Azilra
    
    ~SlopakiaScore = SlopakiaScore + 1
    ->Evaluate


=== Evaluate ===
เจ้าได้ {SlopakiaScore}/5 คะแนน #speaker:อาซิลรา #portrait:Azilra
{
- SlopakiaScore < 3: ->BadGrade
- SlopakiaScore >= 3: ->GoodGrade
}
->DONE


//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra

=== BadGrade ===
เจ้าทำได้แค่นี้งั้นเรอะ!? อย่าหวังเลยว่าจะออกไปจากช่วงเวลานี้ได้ จงติดอยู่ในวังวนอันไร้สิ้นสุดนี้เถอะ เจ้ามนุษย์ #speaker:อาซิลรา #portrait:Azilra
->question1

=== GoodGrade ===
เก่งมาก เจ้ามนุษย์ เจ้าสามารถผ่านบททดสอบนี้ได้ แต่ที่เหลือหละ? ข้าหวังว่าเจอกันครั้งหน้า เจ้ายังคงเก่งให้ได้แบบนี้อยู่นะ วะฮะฮะฮ่า! #speaker:อาซิลรา #portrait:Azilra

พูดมากจริงเห้ย! เดี๋ยวเหอะ เดี๋ยวชั้นจะไปกระชากหน้ากากของนายก็มาเอง! #speaker:Player #portrait:Player
->DONE
