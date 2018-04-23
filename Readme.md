# How to show the grandchildren collection in the DetailView


<p>Suppose that we have the Master class, which has a one-to-many association with the Detail class. The Detail class has the one-to-many association with the SubDetail class. This example demonstrates how to show a collection of all SubDetail objects, associated with the Detail objects of the certain Master object, in the Master DetailView.<br> To implement this, an additional collection property - <strong>SubDetails</strong> - is implemented in the <strong>Master</strong> class. This collection is populated based on the Details collection when the SubDetails property is accessed for the first time and when the Details collection is changed. See the <strong>Master.cs</strong> file from this example for additional information.</p>
<p><strong>See Also:</strong><br> <a href="http://documentation.devexpress.com/#XPO/CustomDocument2038"><u>Creating Criteria<br><a href="https://www.devexpress.com/Support/Center/p/Q529262">How to modify the E1448 example to filter Grandchildren ListView by selected children in the master DetailView</a><br></u></a></p>

<br/>

