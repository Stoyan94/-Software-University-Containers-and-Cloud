terraform {
  required_providers {
    azurerm = {
      source  = "hashicorp/azurerm"
      version = "4.25.0"
    }
  }
}


provider "azurerm" {
  features {}
  subscription_id = "4f627dc8-8f5a-4112-a072-9284f6d182d0"
}

resource "random_integer" "random_integer" {
  min = 10000
  max = 99999
}

resource "azurerm_resource_group" "arg" {
  name     = "ContactBookRG${random_integer.random_integer.result}"
  location = "italy North"
}

resource "azurerm_service_plan" "asp" {
  name                = "ContactsBookServicePlan"
  resource_group_name = azurerm_resource_group.arg.name
  location            = azurerm_resource_group.arg.location
  os_type             = "Linux"
  sku_name            = "F1"
}


resource "azurerm_linux_web_app" "alwa" {
  name                = "ContactsBook"
  resource_group_name = azurerm_resource_group.arg.name
  location            = azurerm_service_plan.asp.location
  service_plan_id     = azurerm_service_plan.asp.id

  site_config {
    application_stack {
      node_version = "16-lts"
    }
    always_on = false
  }
}

resource "azurerm_app_service_source_control" "example" {
  app_id   = azurerm_linux_web_app.alwa.id
  repo_url = "https://github.com/nakov/ContactBook"
  branch   = "master"
  use_manual_integration = true
}