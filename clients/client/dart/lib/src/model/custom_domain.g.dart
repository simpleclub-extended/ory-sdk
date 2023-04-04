// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'custom_domain.dart';

// **************************************************************************
// BuiltValueGenerator
// **************************************************************************

class _$CustomDomain extends CustomDomain {
  @override
  final String? cookieDomain;
  @override
  final BuiltList<String>? corsAllowedOrigins;
  @override
  final bool? corsEnabled;
  @override
  final DateTime? createdAt;
  @override
  final String? customUiBaseUrl;
  @override
  final String? hostname;
  @override
  final String? id;
  @override
  final DateTime? updatedAt;
  @override
  final BuiltList<String>? verificationErrors;
  @override
  final String? verificationStatus;

  factory _$CustomDomain([void Function(CustomDomainBuilder)? updates]) =>
      (new CustomDomainBuilder()..update(updates))._build();

  _$CustomDomain._(
      {this.cookieDomain,
      this.corsAllowedOrigins,
      this.corsEnabled,
      this.createdAt,
      this.customUiBaseUrl,
      this.hostname,
      this.id,
      this.updatedAt,
      this.verificationErrors,
      this.verificationStatus})
      : super._();

  @override
  CustomDomain rebuild(void Function(CustomDomainBuilder) updates) =>
      (toBuilder()..update(updates)).build();

  @override
  CustomDomainBuilder toBuilder() => new CustomDomainBuilder()..replace(this);

  @override
  bool operator ==(Object other) {
    if (identical(other, this)) return true;
    return other is CustomDomain &&
        cookieDomain == other.cookieDomain &&
        corsAllowedOrigins == other.corsAllowedOrigins &&
        corsEnabled == other.corsEnabled &&
        createdAt == other.createdAt &&
        customUiBaseUrl == other.customUiBaseUrl &&
        hostname == other.hostname &&
        id == other.id &&
        updatedAt == other.updatedAt &&
        verificationErrors == other.verificationErrors &&
        verificationStatus == other.verificationStatus;
  }

  @override
  int get hashCode {
    var _$hash = 0;
    _$hash = $jc(_$hash, cookieDomain.hashCode);
    _$hash = $jc(_$hash, corsAllowedOrigins.hashCode);
    _$hash = $jc(_$hash, corsEnabled.hashCode);
    _$hash = $jc(_$hash, createdAt.hashCode);
    _$hash = $jc(_$hash, customUiBaseUrl.hashCode);
    _$hash = $jc(_$hash, hostname.hashCode);
    _$hash = $jc(_$hash, id.hashCode);
    _$hash = $jc(_$hash, updatedAt.hashCode);
    _$hash = $jc(_$hash, verificationErrors.hashCode);
    _$hash = $jc(_$hash, verificationStatus.hashCode);
    _$hash = $jf(_$hash);
    return _$hash;
  }

  @override
  String toString() {
    return (newBuiltValueToStringHelper(r'CustomDomain')
          ..add('cookieDomain', cookieDomain)
          ..add('corsAllowedOrigins', corsAllowedOrigins)
          ..add('corsEnabled', corsEnabled)
          ..add('createdAt', createdAt)
          ..add('customUiBaseUrl', customUiBaseUrl)
          ..add('hostname', hostname)
          ..add('id', id)
          ..add('updatedAt', updatedAt)
          ..add('verificationErrors', verificationErrors)
          ..add('verificationStatus', verificationStatus))
        .toString();
  }
}

class CustomDomainBuilder
    implements Builder<CustomDomain, CustomDomainBuilder> {
  _$CustomDomain? _$v;

  String? _cookieDomain;
  String? get cookieDomain => _$this._cookieDomain;
  set cookieDomain(String? cookieDomain) => _$this._cookieDomain = cookieDomain;

  ListBuilder<String>? _corsAllowedOrigins;
  ListBuilder<String> get corsAllowedOrigins =>
      _$this._corsAllowedOrigins ??= new ListBuilder<String>();
  set corsAllowedOrigins(ListBuilder<String>? corsAllowedOrigins) =>
      _$this._corsAllowedOrigins = corsAllowedOrigins;

  bool? _corsEnabled;
  bool? get corsEnabled => _$this._corsEnabled;
  set corsEnabled(bool? corsEnabled) => _$this._corsEnabled = corsEnabled;

  DateTime? _createdAt;
  DateTime? get createdAt => _$this._createdAt;
  set createdAt(DateTime? createdAt) => _$this._createdAt = createdAt;

  String? _customUiBaseUrl;
  String? get customUiBaseUrl => _$this._customUiBaseUrl;
  set customUiBaseUrl(String? customUiBaseUrl) =>
      _$this._customUiBaseUrl = customUiBaseUrl;

  String? _hostname;
  String? get hostname => _$this._hostname;
  set hostname(String? hostname) => _$this._hostname = hostname;

  String? _id;
  String? get id => _$this._id;
  set id(String? id) => _$this._id = id;

  DateTime? _updatedAt;
  DateTime? get updatedAt => _$this._updatedAt;
  set updatedAt(DateTime? updatedAt) => _$this._updatedAt = updatedAt;

  ListBuilder<String>? _verificationErrors;
  ListBuilder<String> get verificationErrors =>
      _$this._verificationErrors ??= new ListBuilder<String>();
  set verificationErrors(ListBuilder<String>? verificationErrors) =>
      _$this._verificationErrors = verificationErrors;

  String? _verificationStatus;
  String? get verificationStatus => _$this._verificationStatus;
  set verificationStatus(String? verificationStatus) =>
      _$this._verificationStatus = verificationStatus;

  CustomDomainBuilder() {
    CustomDomain._defaults(this);
  }

  CustomDomainBuilder get _$this {
    final $v = _$v;
    if ($v != null) {
      _cookieDomain = $v.cookieDomain;
      _corsAllowedOrigins = $v.corsAllowedOrigins?.toBuilder();
      _corsEnabled = $v.corsEnabled;
      _createdAt = $v.createdAt;
      _customUiBaseUrl = $v.customUiBaseUrl;
      _hostname = $v.hostname;
      _id = $v.id;
      _updatedAt = $v.updatedAt;
      _verificationErrors = $v.verificationErrors?.toBuilder();
      _verificationStatus = $v.verificationStatus;
      _$v = null;
    }
    return this;
  }

  @override
  void replace(CustomDomain other) {
    ArgumentError.checkNotNull(other, 'other');
    _$v = other as _$CustomDomain;
  }

  @override
  void update(void Function(CustomDomainBuilder)? updates) {
    if (updates != null) updates(this);
  }

  @override
  CustomDomain build() => _build();

  _$CustomDomain _build() {
    _$CustomDomain _$result;
    try {
      _$result = _$v ??
          new _$CustomDomain._(
              cookieDomain: cookieDomain,
              corsAllowedOrigins: _corsAllowedOrigins?.build(),
              corsEnabled: corsEnabled,
              createdAt: createdAt,
              customUiBaseUrl: customUiBaseUrl,
              hostname: hostname,
              id: id,
              updatedAt: updatedAt,
              verificationErrors: _verificationErrors?.build(),
              verificationStatus: verificationStatus);
    } catch (_) {
      late String _$failedField;
      try {
        _$failedField = 'corsAllowedOrigins';
        _corsAllowedOrigins?.build();

        _$failedField = 'verificationErrors';
        _verificationErrors?.build();
      } catch (e) {
        throw new BuiltValueNestedFieldError(
            r'CustomDomain', _$failedField, e.toString());
      }
      rethrow;
    }
    replace(_$result);
    return _$result;
  }
}

// ignore_for_file: deprecated_member_use_from_same_package,type=lint
