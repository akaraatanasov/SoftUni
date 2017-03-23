<?php

/* @Twig/Exception/exception_full.html.twig */
class __TwigTemplate_cbe9749bfaf384cdc52cb1b5e9b97fe1a9b0cabf9d5a1e22e4fd8199aefbaf8c extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        // line 1
        $this->parent = $this->loadTemplate("@Twig/layout.html.twig", "@Twig/Exception/exception_full.html.twig", 1);
        $this->blocks = array(
            'head' => array($this, 'block_head'),
            'title' => array($this, 'block_title'),
            'body' => array($this, 'block_body'),
        );
    }

    protected function doGetParent(array $context)
    {
        return "@Twig/layout.html.twig";
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_f5739edcc7b05944b7baad780bb944c9bfe1ee959871e357e399df3b2c585621 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_f5739edcc7b05944b7baad780bb944c9bfe1ee959871e357e399df3b2c585621->enter($__internal_f5739edcc7b05944b7baad780bb944c9bfe1ee959871e357e399df3b2c585621_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "@Twig/Exception/exception_full.html.twig"));

        $this->parent->display($context, array_merge($this->blocks, $blocks));
        
        $__internal_f5739edcc7b05944b7baad780bb944c9bfe1ee959871e357e399df3b2c585621->leave($__internal_f5739edcc7b05944b7baad780bb944c9bfe1ee959871e357e399df3b2c585621_prof);

    }

    // line 3
    public function block_head($context, array $blocks = array())
    {
        $__internal_1b72d0274116c86048f35987b0af2936c6d912f04ea0bad585289984d93d0975 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_1b72d0274116c86048f35987b0af2936c6d912f04ea0bad585289984d93d0975->enter($__internal_1b72d0274116c86048f35987b0af2936c6d912f04ea0bad585289984d93d0975_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "head"));

        // line 4
        echo "    <link href=\"";
        echo twig_escape_filter($this->env, $this->env->getExtension('Symfony\Bridge\Twig\Extension\HttpFoundationExtension')->generateAbsoluteUrl($this->env->getExtension('Symfony\Bridge\Twig\Extension\AssetExtension')->getAssetUrl("bundles/framework/css/exception.css")), "html", null, true);
        echo "\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
";
        
        $__internal_1b72d0274116c86048f35987b0af2936c6d912f04ea0bad585289984d93d0975->leave($__internal_1b72d0274116c86048f35987b0af2936c6d912f04ea0bad585289984d93d0975_prof);

    }

    // line 7
    public function block_title($context, array $blocks = array())
    {
        $__internal_05b09035df20cf8dd5d3b40703b0ce2a99b75c74afbc1e243ff592eebcf724c6 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_05b09035df20cf8dd5d3b40703b0ce2a99b75c74afbc1e243ff592eebcf724c6->enter($__internal_05b09035df20cf8dd5d3b40703b0ce2a99b75c74afbc1e243ff592eebcf724c6_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "title"));

        // line 8
        echo "    ";
        echo twig_escape_filter($this->env, $this->getAttribute((isset($context["exception"]) ? $context["exception"] : $this->getContext($context, "exception")), "message", array()), "html", null, true);
        echo " (";
        echo twig_escape_filter($this->env, (isset($context["status_code"]) ? $context["status_code"] : $this->getContext($context, "status_code")), "html", null, true);
        echo " ";
        echo twig_escape_filter($this->env, (isset($context["status_text"]) ? $context["status_text"] : $this->getContext($context, "status_text")), "html", null, true);
        echo ")
";
        
        $__internal_05b09035df20cf8dd5d3b40703b0ce2a99b75c74afbc1e243ff592eebcf724c6->leave($__internal_05b09035df20cf8dd5d3b40703b0ce2a99b75c74afbc1e243ff592eebcf724c6_prof);

    }

    // line 11
    public function block_body($context, array $blocks = array())
    {
        $__internal_4747007cc0e4f3fd90095378cd7e610f9686d557fae3e4cbba84fd549686ec46 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_4747007cc0e4f3fd90095378cd7e610f9686d557fae3e4cbba84fd549686ec46->enter($__internal_4747007cc0e4f3fd90095378cd7e610f9686d557fae3e4cbba84fd549686ec46_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "body"));

        // line 12
        echo "    ";
        $this->loadTemplate("@Twig/Exception/exception.html.twig", "@Twig/Exception/exception_full.html.twig", 12)->display($context);
        
        $__internal_4747007cc0e4f3fd90095378cd7e610f9686d557fae3e4cbba84fd549686ec46->leave($__internal_4747007cc0e4f3fd90095378cd7e610f9686d557fae3e4cbba84fd549686ec46_prof);

    }

    public function getTemplateName()
    {
        return "@Twig/Exception/exception_full.html.twig";
    }

    public function isTraitable()
    {
        return false;
    }

    public function getDebugInfo()
    {
        return array (  78 => 12,  72 => 11,  58 => 8,  52 => 7,  42 => 4,  36 => 3,  11 => 1,);
    }

    public function getSource()
    {
        return "{% extends '@Twig/layout.html.twig' %}

{% block head %}
    <link href=\"{{ absolute_url(asset('bundles/framework/css/exception.css')) }}\" rel=\"stylesheet\" type=\"text/css\" media=\"all\" />
{% endblock %}

{% block title %}
    {{ exception.message }} ({{ status_code }} {{ status_text }})
{% endblock %}

{% block body %}
    {% include '@Twig/Exception/exception.html.twig' %}
{% endblock %}
";
    }
}
