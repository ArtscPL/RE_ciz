INCLUDE globals.ink

//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra

{isC302 == true && isCC302 == false: ->SolveChest302 | ->general}

=== general ===
.

กล่องปริศนาพิเศษ ต้องมีภารกิจจากย่าสมุนไพรและจัดการปีศาจต้นไม้ครบจำนวนแล้วเท่านั้นถึงจะเปิดกล่องนี้ได้
->DONE

=== SolveChest302 ===
คน 8 คนซึ่งเป็นเพื่อนกันได้เข้าพักในโรงแรม โดยพักห้อง 3 ห้อง ห้องแรกพักได้ 2 คน ห้องที่สองและสามพักห้องละได้ 3 คน จะมีวิธีจัดคนเข้าห้องพักได้กี่วิธี

+ [1020]
    เหมือนจะไม่ถูกแหะ #speaker:Player #portrait:Player
    ->SolveChest302
+ [560]
    ->GetLeaf302
+ [1440]
    เหมือนจะไม่ถูกแหะ #speaker:Player #portrait:Player
    ->SolveChest302
+ [720]
    เหมือนจะไม่ถูกแหะ #speaker:Player #portrait:Player
    ->SolveChest302

=== GetLeaf302 ===
กล่องนี้หินกว่าที่ผ่านมานิดหน่อยแฮะ? หวังว่าจะมีอะไรช่วยย่าสมุนไพรได้จริงๆนะ#speaker:Player #portrait:Player

นั่น..อะไรหนะ? ใบไม้แห้ง? ใครมันเอาใบไม้แห้งมาใส่ในกล่องนี้กันฟะ?#speaker:อาซิลรา #portrait:Azilra

นี่... น่าจะเป็นสิ่งที่ย่าสมุนไพรตามหานะ ยังไงก็ต้องถามดูก่อนนั่นแหละ ชั้นไม่คิดว่าอะไรก็ตามที่อยู่ในกล่องปริศนาจะไร้ประโยชน์หรอกนะ#speaker:Player #portrait:Player

~isCC302 = true
->DONE