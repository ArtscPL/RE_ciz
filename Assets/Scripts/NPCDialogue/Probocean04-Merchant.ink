INCLUDE globals.ink

//#speaker:เจ้าของร้าน #portrait:PMerchant

->general

=== general ===
ยินดีต้อนรับสู่ร้านค้าของเมืองกลางทะเลที่สวยงามที่สุด #speaker:เจ้าของร้าน #portrait:PMerchant

+ [เข้าสู่ร้านค้า]
    ~Cshop = true
    [เข้าสู่ร้านขายของ]
    ->DONE
+ [เดินผ่าน]
    ไม่มีอะไรครับ ไว้มีเดี๋ยวจะแวะมาใหม่นะครับ #speaker:Player #portrait:Player
    ->DONE