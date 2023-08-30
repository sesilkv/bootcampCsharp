using System.Diagnostics;

class Program 
{
	static void Main()
	{
		Trace.Listeners.Clear();
		// using for external resource (file)
		using(TextWriterTraceListener traceListener = new TextWriterTraceListener("myTraceOutput.txt"))
		{
			Trace.Listeners.Add(traceListener);
			
			Trace.Assert(true, "This is trace false");
			Debug.Assert(false, "This is debug false");
			Trace.WriteLine("This is trace statement");
			
			// flush: Clears all buffers for the current writer and causes any buffered data to be written to the underlying stream
			traceListener.Flush();
			//  Closes the current StreamWriter object and the underlying stream
			traceListener.Close();
		}
	}
}