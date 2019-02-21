# Research-Thread

Life Cycle
> 1. The Unstarted State - thread ถูกสร้างแต่ยังไม่ถูกเรียก
> 2. The Ready State - thread พร้อมสำหรับ execute และกำลังรอ การประมวลผลของ CPU
> 3. The Not Runnable State - thread ไม่สามารถ execute ได้เนื่องจากสาเหตุบางอย่างเช่น
	- Sleep method has been called (สั่งให้ thread sleep) 
			> thread sleep จะถูกปลุกถ้าหากมี thread อื่นๆ เรียก method interrupt
			* sleep คือ method แบบ static หมายความว่า ถ้า method sleep ถูกเรียก มันจะส่งผลต่อ thread ปัจจุบันที่ทำงานอยู่ทันที
		-> Wait method has been called  (สั่งให้ thread Wait)
			* คล้ายๆกับ sleep แต่แตกต่างตรงที่  wait ถูกเรียก โดย Object  ไม่ใช่ thread
			* Object.wait() จะถูกปลุกด้วย Object.notify() หรือว่า notifyAll()
			* จะต้องถูก call จาก synchronized context
		-> Blocked by I/O operations (ถูกบล็อกจาก hardware || software )
	4. The Dead State - thread ถูก execute แล้ว หรือว่าถูก aborted 
REF -> http://www.albahari.com/threading/part2.aspx#_ThreadState

# 1.Set พารามิเตอร์ method to threads 
	สามารถส่ง parameter ไปยัง method ได้ (1 object เท่านั้น) 
	EXAM  - > thread.start(method(parameter))
http://marcuscode.com/lang/csharp/threads

# 2.Suspend & Resume
  > asdas
