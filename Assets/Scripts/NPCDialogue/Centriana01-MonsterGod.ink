INCLUDE globals.ink

//->WintheFight
{
-isS105 == true && MustLoseInThisFight == false: ->meetMonsterGod
-isS105 == true && MustLoseInThisFight == true: ->lostat105 
-isS107 == true && isB107 == false: ->fightat107
-isB107 == true && isC107 == false: ->WintheFight
}


//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:จ้าวหมาป่า #portrait:MonsterGod

=== meetMonsterGod ===
เฮ้ เจ้าเด็กอวดดี ชั้นรู้สึกว่ามีบางอย่างไม่ถูกต้อง  #speaker:อาซิลรา #portrait:Azilra
ว่าใครเป็นเด็กอวดดีกันฟะ! ไอเจ้าลูกไฟลอยได้! จิตปรุงแต่งรึเปล่า? #speaker:Player #portrait:Player
นี่นายไม่ได้สังเกตรึไงว่าแถวนี้บรรยากาศมันแปลกๆหนะ! #speaker:อาซิลรา #portrait:Azilra
จิต ปรุง แต่ง!  #speaker:Player #portrait:Player
(หันกลับไปเจอสิ่งมีชีวิตขนาดมหึมา) #speaker:Player #portrait:Player
ชั้นว่าจิตของชั้นก็เริ่มโดนปรุงแต่งแล้วเหมือนกัน #speaker:Player #portrait:Player
เตรียมตัวให้ไว! พ่อนายมาแล้วนั่นหนะ! #speaker:อาซิลรา #portrait:Azilra
พ่อชั้นไม่ได้ตัวใหญ่ขนาดนี้โว้ย! #speaker:Player #portrait:Player
~MustLoseInThisFight = true
~fightBoss = true
(ผู้เล่นจำเป็นต้องสนทนากับจ้าวหมาป่าอีกครั้งหลังจากจบการต่อสู้)
->DONE

=== lostat105 ===
อึก... มันแข็งแกร่งเกินไป พลังชีวิตมหาศาลนั่นมันอะไร นี่มันบอสที่ควรอยู่แถวหมู่บ้านเริ่มต้นหรอฟะ! #speaker:Player #portrait:Player
อย่าลืมว่าเจ้าเมืองให้เรามาสำรวจ! โกยให้ไวเลย! ไปอธิบายให้เจ้าเมืองฟังก่อน! #speaker:อาซิลรา #portrait:Azilra
~isC105 = true
->DONE

=== fightat107 ===
ได้เวลาล้างแค้นแล้ว! แต่เดี๋ยวนะ! ทำไมชั้นถึงไม่รู้สึกถึงความแตกต่างเลยหละ! #speaker:Player #portrait:Player

เจ้างั่งก็ยังเป็นเจ้างั่ง แว่นนั่นเป็นอุปกรณ์เวทมนตร์ประเภทกดใช้ ในตอนนี้นายก็น่าจะสัมผัสถึงทักษะพิเศษที่แฝงอยู่ได้แล้วหละ #speaker:อาซิลรา #portrait:Azilra

อารมณ์เหมือนต้องกดสกิลพิเศษตีบอสในเกม RPG เลยแฮะ แล้วไออุปกรณ์เวทมนตร์ประเภทกดใช้นี่มันอะไร ไม่มีชื่ออื่นที่ดีกว่านี้เรอะ แต่ช่างมันเหอะ ได้เวลาแสดงธาตุแท้ให้ชั้นได้เห็นแล้วเจ้าตัวใหญ่!! #speaker:Player #portrait:Player

กรรร ข้าแข็งแกร่งกว่าใครๆ! ด้วยพลังนี้ ข้าจะไม่มีทางแพ้ใคร! เมืองแห่งนี้ต้องโดนถล่มให้ราบคาบ! #speaker:จ้าวหมาป่า #portrait:MonsterGod

นายคิดเหมือนชั้นรึเปล่า B1 #speaker:Player #portrait:Player

ชั้นเกลียดการคิดแบบเดียวกับนายนะ B2 ไอนี่มันพูดได้ด้วยอะ #speaker:อาซิลรา #portrait:Azilra

เฮ้! พี่เบิ้ม! ชั้นได้ยินที่นายพูดนะ ทำไมนายต้องโจมตีเมืองด้วยหละ พอจะบอกได้มะ? #speaker:Player #portrait:Player

เจ้า ไม่ มี สิทธิ์ ถาม ข้า! สิ่ง มี ชีวิต ชั้น ต่ำ! ข้า คือ เทพ! #speaker:จ้าวหมาป่า #portrait:MonsterGod

ตบมันก่อนค่อยถามละกัน ตอนนี้เราไม่น่าคุยกันรู้เรื่องนะ อย่าลืมใช้พลังของแว่นด้วยหละ #speaker:อาซิลรา #portrait:Azilra

รู้แล้วหน่า จะเอาความจริงออกจากปากของแกให้ได้ #speaker:Player #portrait:Player

(ผู้เล่นจำเป็นต้องสนทนากับจ้าวหมาป่าอีกครั้งหลังจากเอาชนะได้แล้ว)
//fight scene trigger
~fightBoss = true
//set isB107 = true when kill boss
->DONE

=== WintheFight ===
ทำไม! ด้วยพลังที่ข้าได้รับมา! ด้วยพลังแห่งเทพ! ไม่ควรจะมีใครที่จะหยุดข้าได้! #speaker:จ้าวหมาป่า #portrait:MonsterGod

ได้รับมา? ใครให้มา? บอกให้ชัดเจนหน่อยได้มั้ย? #speaker:อาซิลรา #portrait:Azilra

เหอะๆๆ เจ้าพวกสิ่งมีชีวิตชั้นต่ำ ต่อให้เจ้าชนะข้าได้ เทพองค์อื่นๆก็จะกำจัดเจ้าได้อยู่ดี ข้าเป็นเพียงแค่เทพที่ไม่สมบูรณ์เท่านั้น วะฮะฮะฮ่า! #speaker:จ้าวหมาป่า #portrait:MonsterGod

(จากไปอย่างสงบ) #speaker:จ้าวหมาป่า #portrait:MonsterGod

ค่อนข้างจี้ดอยู่เหมือนกันแหะ เทพองค์อื่น? เห็นอนาคตเลยว่าชั้นจะต้องเจอกับอะไร  #speaker:Player #portrait:Player

กลับไปให้เจ้าเมืองกันเถอะ ลองไปเล่าเรื่องทุกอย่างให้ฟัง เขาอาจจะรู้อะไรบางอย่างก็ได้ หรือต่อให้ไม่รู้ก็อาจจะชี้ทางให้เราได้ #speaker:อาซิลรา #portrait:Azilra

~isC107 = true
->DONE