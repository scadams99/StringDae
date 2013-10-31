/*
<fusedoc fuse="showHideDiv.js" specification="1.0" language="Javascript">
  <responsibilities>
  	 i am the functions that show and hide divs on a page.
  </responsibilities>
  <properties>
     <history email=""
	          author="Samuel Adams"
			  type="create"
			  date="07/18/08" />
  </properties>
  <io>
     <in>id : the div element id to show or hide
     </in>
     <in>rs : the number of elements in a list to show or hide
     </in>
  </io>
</fusedoc>
*/
function showdiv(id) {
		if(document.getElementById(id).style.display=="none") {			
   			document.getElementById(id).style.display="block";
 		}
		else {			
   			document.getElementById(id).style.display="none";
			document.getElementById(id).height="35px";
   		}
	}

function hidediv(id) {		
		document.getElementById(id).style.display = 'none';
	}

function showall(rs) {
var text = document.getElementById("displayText");
	for (x=1;x<=rs;x++)
	{
	
		if(document.getElementById(x).style.display=="none") {			
			document.getElementById(x).style.display="block";			
			text.innerHTML = "&nbsp;Hide All Detail&nbsp;";
		}
		else {			
			document.getElementById(x).style.display="none";
			document.getElementById(x).height="35px";
			 text.innerHTML = "&nbsp;Show All Detail&nbsp;";
		}
	
	}	
}		