INCLUDE globals.ink
//#speaker:เจ้าของร้าน #portrait:CaMerchant

->general

=== general ===
ร้านของเราขายดีที่สุดในเมืองนี้ เพราะมีแค่ร้านเราที่เปิดยังไงหละ ฮ่าๆๆ #speaker:เจ้าของร้าน #portrait:CaMerchant

+ [เข้าสู่ร้านค้า]
    ~Cshop = true
    [เข้าสู่ร้านขายของ]
    ->DONE
+ [เดินผ่าน]
    ไม่มีอะไรครับ ไว้มีเดี๋ยวจะแวะมาใหม่นะครับ #speaker:Player #portrait:Player
    ->DONE