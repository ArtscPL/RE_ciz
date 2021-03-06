INCLUDE globals.ink
->general
//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:ช่างตีเหล็ก #portrait:BlackF

=== general ===
~questAccepted = false
~Cshop = false
~Ccraft = false
สายันสวัสดิ์เพื่อนยาก มีอะไรให้เราช่วยไหม?#speaker:ช่างตีเหล็ก #portrait:BlackF

+ [ทำภารกิจ]
    {isS304 == true && isD304 == false: ->finish304}
    {isD304 == true && isS305 == false: ->start305}
    {isC305 == true && isD305 == false: ->finish305}
    ขณะนี้ยังไม่มีภารกิจที่สามารถทำได้#speaker:ช่างตีเหล็ก #portrait:BlackF
    ->DONE
+ [สร้างอุปกรณ์]
    ~Ccraft = true
    [เข้าสู่กระบวนการสร้างอุปกรณ์]
    ->DONE
+ [เดินผ่าน]
    ไม่มีอะไรครับ ไว้มีเดี๋ยวจะมาหานะครับ #speaker:Player #portrait:Player
    ->DONE

=== finish304 ===
สายันสวัสดิ์เพื่อนยาก มีอะไรให้ช่วยเป็นพิเศษรึเปล่าหละ?#speaker:ช่างตีเหล็ก #portrait:BlackF

(อธิบายสถานการณ์)#speaker:Player #portrait:Player

อุปกรณ์ที่สามารถใช้พลังคำสาปได้สินะ เป็นคำขอที่ยากเอาเรื่องเลยนะเพื่อนยาก #speaker:ช่างตีเหล็ก #portrait:BlackF

มีอะไรที่พวกเราพอจะช่วยได้ไหม หรือต้องการอะไรเป็นพิเศษในการสร้างรึเปล่า?#speaker:Player #portrait:Player

แน่นอน สิ่งที่จำเป็นในการสร้างอุปกรณ์ต้องสาปก็คือความทนทานของวัสดุที่แข็งแรงมากพอไม่ให้โดนทำลายทำให้คำสาปย้อนกลับมาทำร้ายผู้ใช้ #speaker:ช่างตีเหล็ก #portrait:BlackF

จากนั้นก็คือพลังเวทย์ที่ใช้ยับยั้งคำสาป และท้ายที่สุดก็คือตัวคำสาปเอง นายจำเป็นต้องไปเตรียมวัตถุดิบมาให้หน่อยนะเพื่อนยาก เพราะงานนี้มันยุ่งยากใช่เล่น#speaker:ช่างตีเหล็ก #portrait:BlackF

ไม่มีปัญหา เพียงแค่บอกมาเราก็พร้อมจะช่วยเสมอ#speaker:Player #portrait:Player

งานนี้ต้องมีการเตรียมตัวกันหน่อย เอาหละเพื่อนยาก นายไปเตรียมตัวของฝั่งนายเถอะ เดี๋ยวเราจะเขียนรายการให้ เตรียมตัวเสร็จแล้วก็มารับไปนะ#speaker:ช่างตีเหล็ก #portrait:BlackF

~questTurnin = true
~isD304 = true
->DONE

=== start305 ===
นายพร้อมแล้วสินะเพื่อนยาก นี่คือใบภารกิจ ชั้นเชื่อว่านายน่าจะมีวัตถุดิบพวกนี้อยู่พอประมาณเลยหละ#speaker:ช่างตีเหล็ก #portrait:BlackF

หืม ดูจากกระเป๋าสัมภาระเจ้านี่แล้ว เราก็แค่ต้องไปจัดการปีศาจต้นไม้อีก 15 ตัวก็น่าจะครบแล้ว#speaker:อาซิลรา #portrait:Azilra
+ [ยอมรับ]
    ไม่มีปัญหา มันอาจจะใช้เวลาเล็กน้อยแต่วัตถุดิบทั้งหมดจะมาถึงก่อนมันสายเกินไปแน่นอน#speaker:Player #portrait:Player
    ~questAccepted = true
    ~isS305 = true
    ->DONE
+ [ปฏิเสธ]
    ขอเวลาเตรียมตัวอีกนิดนึงนะ เดี๋ยวกลับมา#speaker:Player #portrait:Player
    ->DONE

=== finish305 ===
~questTurnin = true
~isD305 = true
สุดยอดไปเลยเพื่อน นายไม่ได้ใช้เวลานานอย่างที่คิด เอาหละได้เวลาสร้างอุปกรณ์ต้องสาปแล้ว#speaker:ช่างตีเหล็ก #portrait:BlackF

เอ้า! เสร็จแล้วๆ นี่คือกำไลต้องสาป มันสามารถปลดปล่อยคำสาปที่รุนแรงมากพอจะหยุดพลังในการฟื้นฟูของเทพแห่งป่าได้แน่นอน#speaker:ช่างตีเหล็ก #portrait:BlackF

ขอบคุณมากๆ ท่านช่างตีเหล็กทีนี้เมืองฟอเรติน่าก็มีความหวังแล้ว#speaker:Player #portrait:Player

ยินดีที่ได้ช่วย ชาวเมืองที่นี่ดีกับเรามากๆเลย คอยช่วยอะไรหลายๆอย่าง หวังว่าครั้งนี้จะตอบแทนพวกเขาได้#speaker:ช่างตีเหล็ก #portrait:BlackF

แน่นอน เราจะรีบกลับไปหาเจ้าเมืองเพื่อคลี่คลายปัญหาให้เร็วที่สุด#speaker:Player #portrait:Player

->DONE