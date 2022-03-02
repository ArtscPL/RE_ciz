INCLUDE globals.ink

-> general

//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
่//#speaker:เฒ่ายา #portrait:CMerchant

== general ==
มีธุระอะไรรึเปล่าหนุ่มน้อย ถ้ามาซื้อของละก็ ยินดีต้อนรับเสมอนะ #speaker:เฒ่ายา #portrait:CMerchant
+ [ทำภารกิจ]
    ->start102
+ [เข้าสู่ร้านค้า]
    ~Cshop = true
    ->DONE
+ [เดินผ่าน]
    ->DONE
->DONE

=== start102 ===
เธอคงเป็นนักผจญภัยหน้าใหม่สินะ มันก็นานแล้วนะเนี่ยที่ไม่ได้มีนักผจญภัยเข้ามาในเมือง #speaker:เฒ่ายา #portrait:CMerchant

->DONE

=== Mquiz ===

->DONE