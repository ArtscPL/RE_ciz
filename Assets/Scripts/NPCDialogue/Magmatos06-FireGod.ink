INCLUDE globals.ink
{isS604 == false:->restriction}
{isS604 == true && isC604 == false: ->604init}
{isC604 == true && isD604 == false: ->ENDING}
//#speaker:Player #portrait:Player
//#speaker:อาซิลรา #portrait:Azilra
//#speaker:เทพแห่งไฟ #portrait:FireGod

=== restriction ===
???

(มังกรปริศนา สันนิษฐานว่าจะเป็นเทพแห่งไฟ)#speaker:เทพแห่งไฟ #portrait:FireGod
->DONE

=== 604init ===
เจ้าคิดดีแล้วจริงๆเหรอ?#speaker:เทพแห่งไฟ #portrait:FireGod

ยังไงชั้นก็ต้องออกไป ขอบใจที่มอบความกล้าให้นะ ชั้นคิดมาแล้วหละ ถ้าออกไปตอนนี้ก็ยังไม่ถึงจุดหมาย ยังไงก็ต้องกลับมาอยู่ดี#speaker:Player #portrait:Player

แล้วทำไมเจ้าถึงยังมาที่นี่?#speaker:เทพแห่งไฟ #portrait:FireGod

ชั้นมีคำขอ ยังไงมนุษย์ทุกคนก็ต้องมาอยู่ด้วยกัน ถ้าชั้นเอาชนะนายได้ นายต้องสร้างอีกทวีปที่ให้มนุษย์ที่ผ่านบททดสอบทั้งหมดมารวมกัน ทำได้รึเปล่า?#speaker:Player #portrait:Player

ไม่มีปัญหา #speaker:เทพแห่งไฟ #portrait:FireGod

งั้นมาเริ่มกันเถอะ ศึกสุดท้ายของพวกเรา#speaker:Player #portrait:Player

ย่อมได้ จงอย่าได้ประมาทหละ#speaker:เทพแห่งไฟ #portrait:FireGod
~fightBoss = true
//change isC604 = true when defeated
->DONE

=== ENDING ===
~questTurnin = true
~isD604 = true
เจ้าทำได้แล้ว ยินดีด้วย #speaker:เทพแห่งไฟ #portrait:FireGod

นายจะทำตามสัญญาใช่มั้ย?#speaker:Player #portrait:Player

แน่นอน แต่ต้องใช้เวลานานเลยหละ แต่ไม่ต้องห่วง เจ้ายังสามารถใช้ชีวิตในโลกนี้ได้ปกติ #speaker:เทพแห่งไฟ #portrait:FireGod

เวลตันแล้ว อะไรตันแล้วมีอะไรให้ทำอีกหรอ?#speaker:Player #portrait:Player

(สมมัติว่าไอคนทำเกมมันอยากสร้างภาคต่อ เดี่ยวมันก็มีแหละมั้ง)#speaker:เทพแห่งไฟ #portrait:FireGod
->DONE