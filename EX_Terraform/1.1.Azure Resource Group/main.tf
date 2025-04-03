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

resource "azurerm_resource_group" "arg" {
  name     = "StoynRG"
  location = "italy North"
}