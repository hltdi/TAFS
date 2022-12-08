//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.8
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace Ufal.UDPipe {

public class EmptyNodes : global::System.IDisposable, global::System.Collections.IEnumerable
    , global::System.Collections.Generic.IEnumerable<EmptyNode>
 {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal EmptyNodes(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(EmptyNodes obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~EmptyNodes() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          udpipe_csharpPINVOKE.delete_EmptyNodes(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public EmptyNodes(global::System.Collections.ICollection c) : this() {
    if (c == null)
      throw new global::System.ArgumentNullException("c");
    foreach (EmptyNode element in c) {
      this.Add(element);
    }
  }

  public bool IsFixedSize {
    get {
      return false;
    }
  }

  public bool IsReadOnly {
    get {
      return false;
    }
  }

  public EmptyNode this[int index]  {
    get {
      return getitem(index);
    }
    set {
      setitem(index, value);
    }
  }

  public int Capacity {
    get {
      return (int)capacity();
    }
    set {
      if (value < size())
        throw new global::System.ArgumentOutOfRangeException("Capacity");
      reserve((uint)value);
    }
  }

  public int Count {
    get {
      return (int)size();
    }
  }

  public bool IsSynchronized {
    get {
      return false;
    }
  }

  public void CopyTo(EmptyNode[] array)
  {
    CopyTo(0, array, 0, this.Count);
  }

  public void CopyTo(EmptyNode[] array, int arrayIndex)
  {
    CopyTo(0, array, arrayIndex, this.Count);
  }

  public void CopyTo(int index, EmptyNode[] array, int arrayIndex, int count)
  {
    if (array == null)
      throw new global::System.ArgumentNullException("array");
    if (index < 0)
      throw new global::System.ArgumentOutOfRangeException("index", "Value is less than zero");
    if (arrayIndex < 0)
      throw new global::System.ArgumentOutOfRangeException("arrayIndex", "Value is less than zero");
    if (count < 0)
      throw new global::System.ArgumentOutOfRangeException("count", "Value is less than zero");
    if (array.Rank > 1)
      throw new global::System.ArgumentException("Multi dimensional array.", "array");
    if (index+count > this.Count || arrayIndex+count > array.Length)
      throw new global::System.ArgumentException("Number of elements to copy is too large.");
    for (int i=0; i<count; i++)
      array.SetValue(getitemcopy(index+i), arrayIndex+i);
  }

  global::System.Collections.Generic.IEnumerator<EmptyNode> global::System.Collections.Generic.IEnumerable<EmptyNode>.GetEnumerator() {
    return new EmptyNodesEnumerator(this);
  }

  global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator() {
    return new EmptyNodesEnumerator(this);
  }

  public EmptyNodesEnumerator GetEnumerator() {
    return new EmptyNodesEnumerator(this);
  }

  // Type-safe enumerator
  /// Note that the IEnumerator documentation requires an InvalidOperationException to be thrown
  /// whenever the collection is modified. This has been done for changes in the size of the
  /// collection but not when one of the elements of the collection is modified as it is a bit
  /// tricky to detect unmanaged code that modifies the collection under our feet.
  public sealed class EmptyNodesEnumerator : global::System.Collections.IEnumerator
    , global::System.Collections.Generic.IEnumerator<EmptyNode>
  {
    private EmptyNodes collectionRef;
    private int currentIndex;
    private object currentObject;
    private int currentSize;

    public EmptyNodesEnumerator(EmptyNodes collection) {
      collectionRef = collection;
      currentIndex = -1;
      currentObject = null;
      currentSize = collectionRef.Count;
    }

    // Type-safe iterator Current
    public EmptyNode Current {
      get {
        if (currentIndex == -1)
          throw new global::System.InvalidOperationException("Enumeration not started.");
        if (currentIndex > currentSize - 1)
          throw new global::System.InvalidOperationException("Enumeration finished.");
        if (currentObject == null)
          throw new global::System.InvalidOperationException("Collection modified.");
        return (EmptyNode)currentObject;
      }
    }

    // Type-unsafe IEnumerator.Current
    object global::System.Collections.IEnumerator.Current {
      get {
        return Current;
      }
    }

    public bool MoveNext() {
      int size = collectionRef.Count;
      bool moveOkay = (currentIndex+1 < size) && (size == currentSize);
      if (moveOkay) {
        currentIndex++;
        currentObject = collectionRef[currentIndex];
      } else {
        currentObject = null;
      }
      return moveOkay;
    }

    public void Reset() {
      currentIndex = -1;
      currentObject = null;
      if (collectionRef.Count != currentSize) {
        throw new global::System.InvalidOperationException("Collection modified.");
      }
    }

    public void Dispose() {
        currentIndex = -1;
        currentObject = null;
    }
  }

  public void Clear() {
    udpipe_csharpPINVOKE.EmptyNodes_Clear(swigCPtr);
  }

  public void Add(EmptyNode x) {
    udpipe_csharpPINVOKE.EmptyNodes_Add(swigCPtr, EmptyNode.getCPtr(x));
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private uint size() {
    uint ret = udpipe_csharpPINVOKE.EmptyNodes_size(swigCPtr);
    return ret;
  }

  private uint capacity() {
    uint ret = udpipe_csharpPINVOKE.EmptyNodes_capacity(swigCPtr);
    return ret;
  }

  private void reserve(uint n) {
    udpipe_csharpPINVOKE.EmptyNodes_reserve(swigCPtr, n);
  }

  public EmptyNodes() : this(udpipe_csharpPINVOKE.new_EmptyNodes__SWIG_0(), true) {
  }

  public EmptyNodes(EmptyNodes other) : this(udpipe_csharpPINVOKE.new_EmptyNodes__SWIG_1(EmptyNodes.getCPtr(other)), true) {
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public EmptyNodes(int capacity) : this(udpipe_csharpPINVOKE.new_EmptyNodes__SWIG_2(capacity), true) {
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  private EmptyNode getitemcopy(int index) {
    EmptyNode ret = new EmptyNode(udpipe_csharpPINVOKE.EmptyNodes_getitemcopy(swigCPtr, index), true);
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private EmptyNode getitem(int index) {
    EmptyNode ret = new EmptyNode(udpipe_csharpPINVOKE.EmptyNodes_getitem(swigCPtr, index), false);
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  private void setitem(int index, EmptyNode val) {
    udpipe_csharpPINVOKE.EmptyNodes_setitem(swigCPtr, index, EmptyNode.getCPtr(val));
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void AddRange(EmptyNodes values) {
    udpipe_csharpPINVOKE.EmptyNodes_AddRange(swigCPtr, EmptyNodes.getCPtr(values));
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public EmptyNodes GetRange(int index, int count) {
    global::System.IntPtr cPtr = udpipe_csharpPINVOKE.EmptyNodes_GetRange(swigCPtr, index, count);
    EmptyNodes ret = (cPtr == global::System.IntPtr.Zero) ? null : new EmptyNodes(cPtr, true);
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Insert(int index, EmptyNode x) {
    udpipe_csharpPINVOKE.EmptyNodes_Insert(swigCPtr, index, EmptyNode.getCPtr(x));
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void InsertRange(int index, EmptyNodes values) {
    udpipe_csharpPINVOKE.EmptyNodes_InsertRange(swigCPtr, index, EmptyNodes.getCPtr(values));
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveAt(int index) {
    udpipe_csharpPINVOKE.EmptyNodes_RemoveAt(swigCPtr, index);
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void RemoveRange(int index, int count) {
    udpipe_csharpPINVOKE.EmptyNodes_RemoveRange(swigCPtr, index, count);
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public static EmptyNodes Repeat(EmptyNode value, int count) {
    global::System.IntPtr cPtr = udpipe_csharpPINVOKE.EmptyNodes_Repeat(EmptyNode.getCPtr(value), count);
    EmptyNodes ret = (cPtr == global::System.IntPtr.Zero) ? null : new EmptyNodes(cPtr, true);
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Reverse() {
    udpipe_csharpPINVOKE.EmptyNodes_Reverse__SWIG_0(swigCPtr);
  }

  public void Reverse(int index, int count) {
    udpipe_csharpPINVOKE.EmptyNodes_Reverse__SWIG_1(swigCPtr, index, count);
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

  public void SetRange(int index, EmptyNodes values) {
    udpipe_csharpPINVOKE.EmptyNodes_SetRange(swigCPtr, index, EmptyNodes.getCPtr(values));
    if (udpipe_csharpPINVOKE.SWIGPendingException.Pending) throw udpipe_csharpPINVOKE.SWIGPendingException.Retrieve();
  }

}

}
