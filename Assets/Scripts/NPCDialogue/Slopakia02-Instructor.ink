INCLUDE globals.ink


{isD201==true && isS202==false: ->start202}
{isC202 == true && isD202== false:->finish202}
{isD203 == true && isS204 == false:->start204}
{isC204 == true && isD204 == false:->finish204}
{isD204 == true:->general}
->general
//->start202

=== general ===
.

หัวใจสำคัญของความแข็งแกร่งก็คือการฝึกฝนอยู่ตลอดเวลายังไงหละ!#speaker:ครูฝึก #portrait:Instructor
->DONE

=== start202 ===
มาทำอะไรที่นี่ไอหนู ที่นี่ไม่ใช่ที่ๆเด็กอย่างเธอจะมาวิ่งเล่นนะ #speaker:ครูฝึก #portrait:Instructor

ผมมาเพื่อฝึกครับ! ผมได้ยินว่าคุณคือครูฝึกที่เก่งมากๆ ดังนั้นขอความกรุณาด้วยครับ!#speaker:Player #portrait:Player

ข้าจะไม่ฝึกเด็กที่ไม่มีพรสวรรค์หรอกนะ ไหนลองตอบมาซิ้เจ้าหนู มีทหารอยู่ 4 คน ถ้าข้าอยากจะให้ทหาร 4 คนนี้เข้าแถว เจ้าคิดว่ามีกี่รูปแบบที่ทหาร 4 คนนี้จะต่อแถวกันได้#speaker:ครูฝึก #portrait:Instructor

(กระซิบ) เอาหละถ้าให้ทหารแต่ละคนเป็น a b c และ d, คนแรกจะเป็นใครก็ได้มาเป็นหัวแถว ดังนั้นจะมี 4 รูปแบบแล้วใช่มั้ย? พอคนที่สองมาต่อก็จะเหลือคนแค่ 3 คนดังนั้นก็จะเหลือเพียง 3 รูปแบบ ซึ่งเอาไปรวมกับคนแรกด้วยหลักการคูณ เราจะได้ 4 x 3 = 12 รูปแบบแล้ว แต่อย่าลืมว่าเรายังเหลืออีก 2 คน 

ใบ้มาขนาดนี้แล้ว ถ้าตอบไม่ได้แกก็เกินเยียวยาแล้วหละ
->202test

=== 202test ===
มีทหารอยู่ 4 คน ถ้าข้าอยากจะให้ทหาร 4 คนนี้เข้าแถว เจ้าคิดว่ามีกี่รูปแบบที่ทหาร 4 คนนี้จะต่อแถวกันได้

+ [24]
    ->202part1
+ [36]
    ไม่มีแม้แต่คุณสมบัติพื้นฐาน เจ้ายังไม่พร้อม! #speaker:ครูฝึก #portrait:Instructor
    ->DONE
+ [12]
    ไม่มีแม้แต่คุณสมบัติพื้นฐาน เจ้ายังไม่พร้อม! #speaker:ครูฝึก #portrait:Instructor
    ->DONE
+ [20]
    ไม่มีแม้แต่คุณสมบัติพื้นฐาน เจ้ายังไม่พร้อม! #speaker:ครูฝึก #portrait:Instructor
    ->DONE


=== 202part1 ===
ยอดเยี่ยม ดูเหมือนว่าจะคุ้มค่าที่จะฝึกเธอนะ เอาหละอย่างแรก! เธอต้องมีความคุ้นเคยกับสภาพแวดล้อมและความสามารถของศัตรูก่อน ไปกำจัดปีศาจน้ำแข็งมา 10 ตัวซะ! เอ้านี่ใบภารกิจ! #speaker:ครูฝึก #portrait:Instructor

+ [ยอมรับ]
    รับทราบครับ! #speaker:Player #portrait:Player
    ~questAccepted = true
    ~isS202 = true
    ->DONE
+ [ปฏิเสธ]
    ขอไปเตรียมตัวมาก่อนนะครับ#speaker:Player #portrait:Player
    ->DONE


=== finish202 ===
~questTurnin = true
~isD202 = true
เธอกลับมาแล้วเด็กน้อย! ถือทำได้ดีมากสำหรับพวกมือใหม่#speaker:ครูฝึก #portrait:Instructor

เอาหละ จงไปเตรียมตัวมาให้พร้อมก่อนจะมารับภารกิจต่อไปซะ#speaker:ครูฝึก #portrait:Instructor
->DONE


//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:ครูฝึก #portrait:Instructor

=== start203 ===
เธอคงจะคุ้นเคยกับพวกปีศาจแล้ว เจ้าพวกปีศาจในแต่ละที่ก็จะมีความสามารถแตกต่างกันไป อย่างปีศาจน้ำแข็งที่สามารถแช่แข็งเธอได้ถ้าเธอไม่ระวัง 

จากที่ดูเผ่าพันธุ์ของเธอคงไม่สามารถทนหนาวได้นาน ไปหาช่างตีเหล็กแล้วขอให้เขาสร้างเสื้อกันหนาวให้เธอซะ!

+ [ยอมรับ]
    รับทราบครับ! #speaker:Player #portrait:Player
    ~questAccepted = true
    ~isS203 = true
    ->DONE
+ [ปฏิเสธ]
    ขอไปเตรียมตัวมาก่อนนะครับ#speaker:Player #portrait:Player
    ->DONE


=== start204 ===
เธอกลับมาแล้วเด็กฝึก! พอดีเลยข้าได้ยินข่าวมาว่าท่านเจ้าเมืองกำลังอยู่ในช่วงวิกฤต มีปีศาจจำนวนมากได้ปิดล้อมท่านเจ้าเมือง รับใบภารกิจนี่ไปแล้วไปกำกัดปีศาจรอบเมือง 10 ตัวเพื่อเปิดทางให้กับท่านเจ้าเมืองซะ!
+ [ยอมรับ]
    รับทราบครับ! #speaker:Player #portrait:Player
    ~questAccepted = true
    ~isS204 = true
    ->DONE
+ [ปฏิเสธ]
    ขอไปเตรียมตัวมาก่อนนะครับ#speaker:Player #portrait:Player
    ->DONE

=== finish204 ===
~questTurnin = true
~isD204 = true
ต้องขอบคุณเธอนะเด็กฝึก ถ้าไม่เช่นนั้นท่านเจ้าเมืองคงจบชีวิตลงที่นั่นแน่ๆ ไปพบท่านเจ้าเมืองซะ เขาต้องการจะขอบคุณเธอเป็นการส่วนตัว
->DONE