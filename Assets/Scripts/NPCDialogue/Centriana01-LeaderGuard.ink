INCLUDE globals.ink

//->finish104
{isS104 == false && isD103 == true: ->start104}
{isC104 == true && isD104 == false: ->finish104}

//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
่//#speaker:หัวหน้ายาม #portrait:GuardLeader

=== start104 ===
เอ่อ ขอโทษครับ คุณหัวหน้ายามรักษาการณ์ ผมอยากจะพบกับท่านเจ้าเมืองครับ 
อ่า เธอนี่เองที่เจ้านั่นพูดถึง #speaker:หัวหน้ายาม #portrait:GuardLeader
เอ๋? เจ้านั่น?
ยามรักษาการณ์หน้าประตูเมืองไง เขามาแจ้งก่อนล่วงหน้าแล้วหละ #speaker:หัวหน้ายาม #portrait:GuardLeader
->Q104

=== Q104 ===
ตอนนี้ยังพบกับเจ้าเมืองไม่ได้หรอกนะ เพราะตอนนี้เรายุ่งหัวหมุนเลยหละ เพราะเราจำเป็นต้องจัดการกับพวกหมาป่าก่อนหนะ #speaker:หัวหน้ายาม #portrait:GuardLeader
+ [รับภารกิจ]
    ให้ผมช่วยไปกำจัดมอนสเตอร์ดุร้ายพวกนั้นไหมครับ ผมน่าจะพอช่วยได้   #speaker:Player #portrait:Player
    ขอบคุณมาก แน่นอนว่าเราไม่ได้จะให้ทำงานฟรีๆหรอกนะ ถ้าเธอจัดการหมาป่าครบ 20 ตัวแล้วก็มารับเงินรางวัลได้เลย ฝากด้วยหละนักผจญภัยหนุ่ม #speaker:หัวหน้ายาม #portrait:GuardLeader
    ~isS104 = true
    ~questAccepted = true
    ->DONE
+ [ปฏิเสธ]
    งั้นไม่เป็นไรครับ ไว้โอกาสหน้าก็ได้  #speaker:Player #portrait:Player
    ->DONE
->DONE

=== finish104 ===
ฮะฮ่า คิดถูกจริงๆที่ไว้ใจเธอ รับเงินรางวัลไปสิแล้วก็ ตอนนี้เธอคงไปหาท่านเจ้าเมืองได้แล้วหละ เขากำลังรออยู่เลย  #speaker:หัวหน้ายาม #portrait:GuardLeader
~isD104 = true
->DONE