MSSA Cohort 3
Course: ISTA-422
Chapter: 01
Name: Lee Sarduy
Date: December 5, 2017

What are the differences between IaaS, PaaS, and SaaS? 
An Infrastructure as a Service (IaaS) cloud vendor runs and manages server farms running virtualization software, enabling you to create VMs that run on the vendor’s infrastructure. Depending on the vendor, you can create a VM running Windows or Linux and install anything you want on it. Azure provides the ability to set up virtual networks, load balancers, and storage and to use many other services that run on its infrastructure. You don’t have control over the hardware or virtualization software, but you do have control over almost everything else. In fact, unlike PaaS, you are completely responsible for it.
With Platform as a Service (PaaS), you deploy your application into an application-hosting environment provided by the cloud service vendor. The developer provides the application, and the PaaS vendor provides the ability to deploy and run it. This frees developers from infrastructure management, allowing them to focus strictly on development.
Software as a Service (SaaS) is software that is centrally hosted and managed for the end customer. It usually is based on a multitenant architecture—a single version of the application is used for all customers. It can be scaled out to multiple instances to ensure the best performance in all locations.
What is the Azure Service Management (ASM) deployment model? What is the Resource Manager deployment model?
The Azure Service Management (ASM) deployment model has been used to deploy services. In the Azure portal, services managed with ASM are referred to as classic. In 2015, Microsoft introduced the Resource Manager deployment model as a modern, more functional replacement for ASM. The Resource Manager deployment model is recommended for all new Azure workloads. .
What is the difference between a control plane and a data plane?
These deployment models are often referred to as control planes because they are used to control services, not just to deploy them. This is different from a data plane, which manages the data used by a service.
What is Role-Based Access Control?
Role-Based Access Control along with the Resource Manager, you can grant permissions at a specified scope: subscription, resource group, or resource. This means you can deploy a set of resources into a resource group and then grant permissions to one or more specific users, groups, or service principal. Those users will only have the permissions granted to those resources in that resource group. This access does not allow them to modify resources in other resource groups. You can also give a user permission to manage a single VM, and that’s all that user will be able to access and administer.
Why would you want to create a custom role for role-based access control?
If none of the built-in roles and no combination of the built-in roles provides exactly what you need, you can create a custom role.
Consider the Azure portal. What is the dashboard? What is the hub? What is a blade?
The dashboard is the customizable UI that you see when you log into the Azure portal. The hub is the menu on the left of the screen that shows you a core set of options such as Resource Groups, All Resources, and Recent. Blades are the separate sections that get opened as you make selections, when the portal scrolls to the right.
Access the conceptual Azure documentation on Github. Search the documentation and answer this question: What happens when I reach the spending limit?
You might have your Azure subscription disabled because you reached your spending limit, have an overdue bill, hit your credit card limit, or because the subscription was canceled by the Account Administrator.
Access the Azure samples on Github. Search for an example that will allow you to download an Azure invoice. Copy the source code to your discussion. (This is Program.cs.)