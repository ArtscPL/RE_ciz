INCLUDE globals.ink
{isCC406 == true && isD406 == false:->finish406}
{isD501 == true && isS502 == false:->start502}
{isC502 == true && isD502 == false:->finish502}
{isD502 == true && isS503 == false:->start503}
{isC503 == true && isD503 == false:->finish503}
->general
//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:ยาม #portrait:GuardCa

=== finish406 ===
~questTurnin = true
~isD406 = true
หน้าใหม่เหรอ? มีจดหมายแนะนำตัวมาด้วย? อ่อยังงี้นี่เอง เรื่องสถานะไม่มีปัญหา เข้าเมืองได้เลย#speaker:ยาม #portrait:GuardCa

เอ่อ..นึกว่าจะต้องทำอะไรก่อนซะอีก การใช้เส้นสายมันก็สบายจริงๆแหะ ว่าแต่นักโบราณคดีอยู่ในเมืองรึเปล่าครับ?#speaker:Player #portrait:Player

อ่อเจ้านั่นนะเหรอ พี่งออกไปได้ไม่นานนี่เอง มาเสียเที่ยวแล้วละมั้ง#speaker:ยาม #portrait:GuardCa

เอ่อ.. ก็ไม่เชิงซะทีเดียว งั้นผมไปพบเจ้าเมืองก่อนละกัน#speaker:Player #portrait:Player
->DONE

=== general ===
อย่าทำอะไรโง่ๆในเมืองหละ แล้วจะหาว่าไม่เตือน #speaker:ยาม #portrait:GuardCa
->DONE

=== finish501 ===
~isD501 = true
~questTurnin = true
กะแล้วว่าต้องกลับมาหา หึๆๆ#speaker:ยาม #portrait:GuardCa

เมืองนี้นี่มันยังไงกันฟะเนี่ย ขนาดยามยังกวนตีนได้ บอกมาซะดีๆนักโบราณคดีไปไหน?#speaker:Player #portrait:Player

เอาหละๆ ไม่หยอกเจ้าก็ได้ เขากับคณะได้ไปสำรวจที่เขตแมกมาทอส พื้นที่ๆอันตรายที่สุดในทวีปนี้ยังไงหละ#speaker:ยาม #portrait:GuardCa

เอ่อ.. มันอันตรายระดับไหนหรอครับ ผมในตอนนี้พร้อมจะไปที่นั่นรึยัง?#speaker:Player #portrait:Player

อย่าพึ่งรีบดิ เรายังไม่เจอเทพที่จะโจมตีเมืองนี้เลย#speaker:อาซิลรา #portrait:Azilra

เทพหรอ? ตอนนี้เมืองยังปกติดีนะ ไม่มีอะไรผิดปกติเลย ถ้าพูดถึงความอันตรายของเขตแมกมาทอส ที่นั่นเต็มไปด้วยลาวาและความผิดปกติมากมาย ถ้าไปในตอนนี้เธอไม่มีทางรอดแน่นอน#speaker:ยาม #portrait:GuardCa

เอ่อ.. มีวิธีที่ทำให้ผมพร้อมจะไปที่นั่นไหมครับ? ยังไงผมก็ต้องไปที่นั่นอยู่ดี#speaker:Player #portrait:Player

มีสิ แต่ตอนนี้ยังไม่สะดวก กลับมาอีกครั้งตอนที่เอ็งพร้อมนะ บะบุย#speaker:ยาม #portrait:GuardCa
->DONE

=== start502 ===
ตอนนี้มีอะไรให้ผมทำรึยัง?#speaker:Player #portrait:Player

มีสิ พอดีเลยมอนสเตอร์รอบๆเมืองนี้เหมาะสำหรับการเตรียมความพร้อมเบื้องต้นได้ เริ่มจากไปจัดการค้างคาวยักษ์ซัก 10 ตัวก่อนแล้วกันให้คุ้นเคย#speaker:ยาม #portrait:GuardCa

นั่นไม่ใช่งานนายหรอ?#speaker:อาซิลรา #portrait:Azilra

จะทำไม่ทำ?#speaker:ยาม #portrait:GuardCa

+ [ยอมรับ]
    ทำก็ทำฟะ#speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS502 = true
    ->DONE
+ [ปฏิเสธ]
    ยัง ยังไม่ทำตอนนี้ รอแปป#speaker:Player #portrait:Player
    ->DONE
    
=== finish502 ===
~questTurnin = true
~isD502 = true
ตอนนี้นายคงคุ้นเคยกับสถานะผิดปกติบ้างเนอะ เรามาพูดถึงวิธีรักษากันบ้าง ร้านยาที่เมืองเราขายน้ำยาล้างมลทินที่จะช่วยรักษาสถานะผิดปกติได้ทุกประเภท#speaker:ยาม #portrait:GuardCa

ไม่ใช่ว่ามันต้องบอกกันก่อนใช้ให้ไปตีไม่ใช่เหรอครับ!?#speaker:Player #portrait:Player

วิธีเลี้ยงลูกแบบคนหัวโบราณไง เจ็บก่อนแล้วถึงจะค่อยรักษา

แต่ตูไม่ได้ถูกเลี้ยงมาแบบนี้โว้ย#speaker:Player #portrait:Player

เอาหน่า ไปซื้อนํ้ายาที่ว่าแล้วกลับมารับอีกงานซะ อย่าใช้เวลานานหละ#speaker:ยาม #portrait:GuardCa
->DONE

=== start503 ===
ตอนนี้มีน้ำยาแล้วไปสู้กับค้างค้าวยักษ์อีก 10 ตัวเพื่อเรียนรู้วิธีการใช้เอาละกันนะ อย่าลืมว่าหลังจากนี้ต้องพกติดตัวไว้ตลอดเวลาด้วยหละ#speaker:ยาม #portrait:GuardCa

+ [ยอมรับ]
    เหมือนผลักลูกตกน้ำแล้วบอกว่าเดี๋ยวมันก็ว่ายน้ำเป็นเองยังไงยังงั้น!?#speaker:Player #portrait:Player
    
    ~questAccepted = true
    ~isS503 = true
    ->DONE
+ [ปฏิเสธ]
    ยัง ยังไม่ทำตอนนี้ รอแปป#speaker:Player #portrait:Player
    ->DONE

=== finish503 ===
~questTurnin = true
~isD503 = true
เสร็จแล้วเฟ้ย#speaker:Player #portrait:Player

พอดีเลยเจ้าหนู เจ้าเมืองกำลังเรียกหาเจ้าอยู่พอดี ปะๆ#speaker:ยาม #portrait:GuardCa
->DONE