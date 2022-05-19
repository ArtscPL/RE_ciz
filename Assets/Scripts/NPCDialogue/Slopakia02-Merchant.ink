INCLUDE globals.ink

//#speaker:เจ้าของร้าน #portrait:SMerchant

->general

=== general ===
ยินดีต้อนรับสู่ร้านค้าเมืองหนาว #speaker:เจ้าของร้าน #portrait:SMerchant

+ [เข้าสู่ร้านค้า]
    ~Cshop = true
    [เข้าสู่ร้านขายของ]
    ->DONE
+ [เดินผ่าน]
    ไม่มีอะไรครับ ไว้มีเดี๋ยวจะแวะมาใหม่นะครับ #speaker:Player #portrait:Player
    ->DONE