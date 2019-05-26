<%@ Page Language="C#"%>
<!DOCTYPE html>
<!-- Example Part 3: Lets add some server side C# code.  ;-)-->
<html>
<head>
	<meta charset="UTF-8">
	<link rel="stylesheet" href="style/site.css">
	<script src="scripts/jquery-1.9.1.js" type="text/javascript"></script>
	<script src="scripts/scripts.js" type="text/javascript"></script>
	<title>Server Status Page</title>
</head>
<body>
	<div id="mainBody">
		<header>
			<img src="http://www.cdm.depaul.edu/PublishingImages/logo_depaul198.png" alt="CDM Logo" title="CDM Logo">
			<hgroup>
				<h1>Server Status Information</h1>
				<h2>Your Server Status Info Page</h2>
			</hgroup>
		</header>
		<section id="serverInfo">
			<p>ASP.NET Server Information</p>
			<ul>
				<li>
				Server Information
					<ol>
						<li>Machine Name: <%=Environment.MachineName%></li>
						<li>Current Directory: <%=Environment.CurrentDirectory%></li>
						<li>Number of Processors: <%=Environment.ProcessorCount%></li>
					</ol>
				</li>
				<li>
				Operating Environment
					<ol>
						<li>Operating System <%=Environment.OSVersion%></li>
						<li>.NET CLR Version <%=Environment.Version.ToString()%></li>
					</ol>
				</li>
				<li>
				Process Information
					<ol>
						<%
							/*This is a code block, we can add ASP.NET Code here.  
							However, I'll just be using this for comments we don't want to get sent to the client.
							
							Environment.WorkingSet returns the value in bytes, we will roughly convert to MB and round it.
							
							Note: This code will crash in Windows 98/ME because Environment.Workset always returns 0.  
							Divide by 0 bad.  Really bad.  In future examples, we should check that the value is not zero before
							we try to divide.  
							*/
							
						%>
						<li>Working Set: <%=(Math.Round(Environment.WorkingSet * 9.5367431640625E-07)).ToString()%> MB</li>
						<li>Running Interactive?: <%=Environment.UserInteractive%></li>
					</ol>
				</li>
			</ul>
		</section>
		<footer>
			<p>For Information about your account, please email <a href="mailto:sagar2332@icloud.com">aagar2332@icloud.com</a></p>
		</footer>
	</div>
</body>
</html>