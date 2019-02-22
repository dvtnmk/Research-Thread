# Research-Thread

## Life Cycle

 1. The Unstarted State - thread ถูกสร้างแต่ยังไม่ถูกเรียก
 2. The Ready State - thread พร้อมสำหรับ execute และกำลังรอ การประมวลผลของ CPU
 3. The Not Runnable State - thread ไม่สามารถ execute ได้เนื่องจากสาเหตุบางอย่างเช่น
	- Sleep method has been called (สั่งให้ thread sleep) 
	  > - thread sleep จะถูกปลุกถ้าหากมี thread อื่นๆ เรียก method interrupt
	  > - sleep คือ method แบบ static หมายความว่า ถ้า method sleep ถูกเรียก มันจะส่งผลต่อ thread ปัจจุบันที่ทำงานอยู่ทันที
	- Wait method has been called  (สั่งให้ thread Wait)
	  > - คล้ายๆกับ sleep แต่แตกต่างตรงที่  wait ถูกเรียก โดย Object  ไม่ใช่ thread
	  > - Object.wait() จะถูกปลุกด้วย Object.notify() หรือว่า notifyAll()
	  > - จะต้องถูก call จาก synchronized context
	  > - Sleep method has been called (สั่งให้ thread sleep) 
	- Blocked by I/O operations (ถูกบล็อกจาก hardware || software )

 4. The Dead State - thread ถูก execute แล้ว หรือว่าถูก aborted 
- REF -> [Click!](http://www.albahari.com/threading/part2.aspx#_ThreadState)

# 1.Pass parameter method to threads 
- สามารถส่ง parameter ไปยัง method ได้ (1 object เท่านั้น) 
```
EXAM  - > thread.start(method(parameter))
EXAM2 - > 
	static void Main()
	{
	  Thread t = new Thread ( () => Print ("Hello from t!") );
	  t.Start();
	}

	static void Print (string message) 
	{
	  Console.WriteLine (message);
	}
```
REF -> [Click!](http://marcuscode.com/lang/csharp/threads)

# 2.Suspend & Resume
  > Suspend คือการระงับการใช้งาน thread ปกติแล้วจะใช้ควบคู่กับ resume (ถูกเลิกใช้แล้วเนื่องจากมีปัญหาเรื่อง security และ ไม่ค่อยมีประโยชน์)
 ```
 EXAM 1 
 	worker.NextTask = "MowTheLawn";
	if ((worker.ThreadState & ThreadState.Suspended) > 0)
	  worker.Resume;
	else
	  // ไม่สามารถ Resume ได้ถ้า ThreadState เป็นสถานะ Running
	  worker.AnotherTaskAwaits = true;
 	
 ```
Ref -> [Click!](http://www.albahari.com/threading/part4.aspx#_Suspend_and_Resume)

# 3. Aborting Threads 
  > Thread Abort โดยปกติแล้วจะใช้สำหรับสั่งให้ Thread หยุดทำงาน
 ```
 EXAM 1
 	class Abort
	{
	  static void Main()
	  {
	    Thread t = new Thread (delegate() { while (true); } );

	    Console.WriteLine (t.ThreadState);     // Unstarted

	    t.Start();
	    Thread.Sleep (1000);
	    Console.WriteLine (t.ThreadState);     // Running

	    t.Abort();
	    Console.WriteLine (t.ThreadState);     // AbortRequested

	    t.Join();
	    Console.WriteLine (t.ThreadState);     // Stopped
	  }
	}
 ```

- **Best Practice - > [Click!](https://docs.microsoft.com/en-us/dotnet/standard/threading/managed-threading-best-practices)**
- **Key word Search Google -> thread.abort() site:stackoverflow.com**
