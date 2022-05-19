INCLUDE globals.ink
{isS504 == false: ->restriction}
{isS504 == true && isSS504 == false: ->504fight}
{isSS504 == true && isC504 == false: ->504after}
{isS506 == true && isC506 == false: ->506init}
{isB506 == true && isC506 == false: ->506after}
//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:เทพแห่งความมืด #portrait:DarkGod

=== restriction ===
???

ถอยด่วน เจ้านี่เก่งเกินกว่าที่นายจะรับมือได้ #speaker:อาซิลรา #portrait:Azilra
->DONE

=== 504fight ===
หวัดดี เทพที่ไม่รู้จัก ขอคุยด้วยหน่อยดิ#speaker:Player #portrait:Player

เจ้าคิดว่าตัวเองเป็นใครกัน เผ่าพันธุ์ชั้นต่ำ ข้าคือเทพแห่งความมืด และข้านี่แหละจะเป็นผู้ที่จะนำพาหายนะมาสู่ทวีปแห่งนี้#speaker:เทพแห่งความมืด #portrait:DarkGod

Racistอีกแล้วโว้ย! เห้ เทพแห่งความมืดพูดงี้ก็มาสู้กันหน่อยดีกว่า ให้พวกเผ่าพันธุ์ชั้นต่ำที่นายเหยียดไปทำลายเมือง ไม่แน่จริงนี่หว่า#speaker:Player #portrait:Player

บังอาจ! ก็ดี ข้าจะจบชีวิตน้อยๆของเจ้าด้วยมือของข้าเอง หลังจากเจ้า เมืองใกล้ๆนี้จะเป็นที่ต่อไป#speaker:เทพแห่งความมืด #portrait:DarkGod

ยั่วง่ายจังอะ!? พลังเพิ่มขึ้นแลกกับ IQ ที่ลดลงสินะ#speaker:อาซิลรา #portrait:Azilra

(ผู้เล่นจำเป็นต้องสนทนากับเทพแห่งความมืดอีกครั้งหลังจบการต่อสู้)
~isSS504 = true
~fightBoss = true
->DONE

=== 504after ===
บ้าอะไร? ไอนี่ก็มีเงื่อนไขแปลก ๆ อีกแล้ว?#speaker:Player #portrait:Player

ทำในสิ่งที่เราถนัดเถอะ#speaker:อาซิลรา #portrait:Azilra

โกย!#speaker:Player #portrait:Player

ชิ หนีไปแล้วเรอะ ไม่เป็นไรยังไงซะ เจ้าก็ต้องตายไปพร้อมกับทวีปนี้อยู่ดี วะฮะฮะฮ่า!#speaker:เทพแห่งความมืด #portrait:DarkGod

~isC504 = true
->DONE

=== 506init ===
เทพแห่งความมืด เรากลับมาแล้ว!#speaker:Player #portrait:Player

กลับมารับความตายซะ เจ้าหนูชั้นต่ำ#speaker:เทพแห่งความมืด #portrait:DarkGod

วอนนัก เดี๋ยวได้นอนโลงแน่นอน#speaker:Player #portrait:Player

นายจะซื้อโลงให้มันหรอ? #speaker:อาซิลรา #portrait:Azilra

ไม่อะ...#speaker:Player #portrait:Player

งั้นเริ่มจริงจังแล้วใช้แหวนนั่นได้แล้ว!#speaker:อาซิลรา #portrait:Azilra

ถ้าความน่าจะเป็นที่นักเรียนคนหนึ่งจะสอบผ่านวิชาแรก และวิชาที่สองเป็น 0.6 และ 0.5 ตามลําดับ ความน่าจะเป็นที่จะสอบผ่านอย่างน้อยหนึ่งวิชา เท่ากับ 0.8 จงหา ความน่าจะเป็นที่นักเรียนคนนี้จะสอบผ่านทั้ง 2 วิชา#speaker:เทพแห่งความมืด #portrait:DarkGod

+ [0.9]
    เอ่อ โทษที เผ่นก่อน! ตอบผิดงะ#speaker:Player #portrait:Player
    ->DONE
+ [0.7]
    เอ่อ โทษที เผ่นก่อน! ตอบผิดงะ#speaker:Player #portrait:Player
    ->DONE
+ [0.5]
    เอ่อ โทษที เผ่นก่อน! ตอบผิดงะ#speaker:Player #portrait:Player
    ->DONE
+ [0.3]
    เจ๋ง! มาสู้กันไอมืด ครั้งนี้เราจะหัวเราะเป็นคนสุดท้าย #speaker:Player #portrait:Player
    
    ~fightBoss = true
    //change isB506 = true when defeat boss
    ->DONE

=== 506after ===
บ้าหน่า... แสงบ้านี้มันโคตรจะสว่างเลย เทพแห่งความมืด อยู่หมายยย#speaker:Player #portrait:Player

เอ่อ...เหมือนว่าอีกฝั่งจะตายไปแล้วหนะ#speaker:อาซิลรา #portrait:Azilra

หะ? ยังไม่ได้ถามอะไรเลยนะเห้ย#speaker:Player #portrait:Player

จำเป็นต้องถามด้วยหรอ ยังไงซะชั้นคิดว่าทุกอย่างมันจะกระจ่างเมื่อนายเอาชนะเทพที่แมกมาทอสได้อยู่ดี#speaker:อาซิลรา #portrait:Azilra

ก็ถูกของนาย กลับไปหาเจ้าเมืองกันเถอะ#speaker:Player #portrait:Player
~isC506 = true
->DONE